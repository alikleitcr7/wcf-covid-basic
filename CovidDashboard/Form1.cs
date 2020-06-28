using CovidDashboard.CovidService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using CovidDashboard.CovidService;

namespace CovidDashboard
{
    public partial class Form1 : Form
    {
        private const string DATE_FORMAT = "yyyy-MM-dd";

        private readonly ICovidService _client;

        public Form1()
        {
            InitializeComponent();

            _client = new CovidServiceClient();

            DisplayMessage.Text = "Loading...";

            // init datetimepicker values
            dateTimePicker_From.Value = DateTime.Now.AddMonths(-4);
            //dateTimePicker_To.Value = DateTime.Now;

            var task = Task.Factory.StartNew(() => _client.GetCountries());

            task.ContinueWith(e =>
            {
                if (e.IsCompleted)
                {
                    List<Country> countries = task.Result;

                    if (countries != null)
                    {
                        Action setFinished = () =>
                        {
                            var bindingSource1 = new BindingSource();
                            bindingSource1.DataSource = countries;

                            comboBox_Countries.DataSource = bindingSource1.DataSource;

                            comboBox_Countries.DisplayMember = "CountryMember";
                            comboBox_Countries.ValueMember = "ISO2";
                            DisplayMessage.Text = "";
                        };

                        Invoke(setFinished);

                    }
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateSummary();
        }

        private void PopulateSummary()
        {
            SetDashboardLoading();

            try
            {
                var task = Task.Factory.StartNew(() => _client.GetGlobalCases());

                task.ContinueWith(r =>
                {
                    if (r.IsCompleted)
                    {
                        GlobalCases summary = task.Result;

                        if (summary != null)
                        {
                            Action setFinished = () =>
                            {
                                SetDashboardNumbers(summary);
                            };

                            Invoke(setFinished);
                        }
                    }
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong");
                SetDashboardNumbers(0, 0, 0, 0, 0, 0, DateTime.Now);
            }
        }

        private void SetDashboardNumbers(GlobalCases globalCases)
        {
            Global global = globalCases.Global;

            SetDashboardNumbers(global.NewConfirmed, global.TotalConfirmed, global.NewDeaths, global.TotalDeaths, global.NewRecovered, global.TotalRecovered, globalCases.Date);
        }

        private void SetDashboardNumbers(CountryCaseByDate latest, CountryCaseByDate before)
        {
            int newConfirmed = 0;
            int newDeath = 0;
            int newRecovered = 0;

            int confirmed = latest.Confirmed;
            int deaths = latest.Deaths;
            int recovered = latest.Recovered;

            if (before != null)
            {
                newConfirmed = confirmed - before.Confirmed;
                newDeath = deaths - before.Deaths;
                newRecovered = recovered - before.Recovered;
            }

            SetDashboardNumbers(newConfirmed, confirmed, newDeath, deaths, newRecovered, recovered, latest.Date);
        }

        private void SetDashboardNumbers(int newConfirmed, int totalConfirmed, int newDeath, int totalDeath, int newRecovered, int totalRecovered, DateTime latestDate)
        {
            label_NewConfirmed.Text = newConfirmed.ToString("n");
            label_TotalConfirmed.Text = totalConfirmed.ToString("n");
            label_NewDeaths.Text = newDeath.ToString("n");
            label_TotalDeaths.Text = totalDeath.ToString("n");
            label_NewRecovered.Text = newRecovered.ToString("n");
            label_TotalRecovered.Text = totalRecovered.ToString("n");
            label_LatestUpdatedDate.Text = "Last Updated on " + latestDate.ToShortDateString();
        }

        private void SetDashboardLoading()
        {
            label_NewConfirmed.Text = "---";
            label_TotalConfirmed.Text = "---";
            label_NewDeaths.Text = "---";
            label_TotalDeaths.Text = "---";
            label_NewRecovered.Text = "---";
            label_TotalRecovered.Text = "---";
            label_LatestUpdatedDate.Text = "---";
        }

        private void ComboBox_Countries_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            Country selectedCountry = comboBox_Countries.SelectedItem as Country;

            // check text if no country selected
            if (selectedCountry == null && !string.IsNullOrEmpty(comboBox_Countries.Text))
            {
                string countryInput = comboBox_Countries.Text;

                // check if the country is in our list (maybe code or name)

                foreach (Country country in comboBox_Countries.Items)
                {
                    if (country.CountryMember.Equals(countryInput, StringComparison.OrdinalIgnoreCase) || country.ISO2.Equals(countryInput, StringComparison.OrdinalIgnoreCase))
                    {
                        selectedCountry = country;
                        break;
                    }
                }

            }

            if (selectedCountry == null)
            {
                MessageBox.Show("Select a country");
                return;
            }

            button_Search.Text = "Fetching...";
            button_Search.Enabled = false;

            button_Reset.Visible = true;

            Action endLoading = () =>
            {
                button_Search.Text = "Fetch";
                button_Search.Enabled = true;
            };

            DateTime fromDate = dateTimePicker_From.Value;
            //DateTime toDate = dateTimePicker_To.Value;

            string countryCode = selectedCountry.ISO2;
            string dateFrom = fromDate.ToString(DATE_FORMAT);
            //string dateTo = toDate.ToString(DATE_FORMAT);

            try
            {
                var task = Task.Factory.StartNew(() => _client.GetByCountry(new GetByCountryLiveParamters()
                {
                    CountryCode = countryCode,
                    From = dateFrom,
                    //To = dateTo,
                }));

                task.ContinueWith(r =>
                {
                    if (r.IsCompleted)
                    {
                        List<CountryCaseByDateViewModel> cases = task.Result?.Select(k => new CountryCaseByDateViewModel()
                        {
                            Confirmed = k.Confirmed,
                            Deaths = k.Deaths,
                            Recovered = k.Recovered,
                            Date = k.Date
                        }).OrderByDescending(k => k.Date).ToList();

                        if (cases != null)
                        {
                            Action setFinished = () =>
                            {
                                if (cases.Count > 0)
                                {
                                    SetDashboardNumbers(cases[0], cases.Count > 1 ? cases[1] : null);
                                }

                                BindingSource bindingSource = new BindingSource
                                {
                                    DataSource = cases
                                };

                                listBox_Results.DataSource = bindingSource.DataSource;
                                listBox_Results.DisplayMember = "DisplayMessage";

                                endLoading();
                            };

                            Invoke(setFinished);
                        }
                        else
                        {
                            Invoke(endLoading);
                        }

                    }
                });
            }
            catch (Exception)
            {
                endLoading();
            }


        }

        private void Button_Reset_Click(object sender, EventArgs e)
        {
            button_Reset.Visible = false;

            PopulateSummary();

            BindingSource bindingSource = new BindingSource
            {
                DataSource = new List<CountryCaseByDate>()
            };

            listBox_Results.DataSource = bindingSource.DataSource;
        }

        private class CountryCaseByDateViewModel : CountryCaseByDate
        {
            public string DisplayMessage
            {
                get
                {
                    return $"{Date.ToShortDateString()} \tConfirmed: {Confirmed} \tDeath: {Deaths} \tRecovered: {Recovered}";
                }
            }
        }
    }
}
