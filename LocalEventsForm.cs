using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        //dotnet-bot (2024). SortedDictionary Class (System.Collections.Generic). [online] Microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.sorteddictionary-2?view=net-8.0 [Accessed 1 Oct. 2024].
        // Sorted dictionary that organizes events by date
        //Hash Tables, Dictionaries, Sorted Dictionaries: A SortedDictionary<DateTime, Queue<Event>> is used to organize events by their date, allowing for efficient retrieval of events in chronological order.
        //Stacks, Queues, Priority Queues: A Queue<Event> is used within the SortedDictionary<DateTime, Queue<Event>> eventsByDate to manage events sorted by date. This is a implementation of a queue to handle events scheduled for specific dates.
        private SortedDictionary<DateTime, Queue<Event>> eventsByDate;

        // Hash set for event categories
        //A HashSet<string> eventCategories is used to store unique event categories, ensuring no duplicates.
        private HashSet<string> eventCategories = new HashSet<string>();
        // The Queue<string> searchHistory is used to store search terms, as a queue for managing user input.
        // Queue to store search history for recommendation feature
        private Queue<string> searchHistory = new Queue<string>();

        //dotnet-bot (2024). HashSet Class (System.Collections.Generic). [online] Microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.hashset-1?view=net-8.0 [Accessed 10 Oct. 2024].

        // HashSet to track displayed events
        //Sets: A HashSet<Event> displayedEvents is used to track events that have been displayed to the user, ensuring uniqueness and preventing duplicates in the recommendations.
        private HashSet<Event> displayedEvents = new HashSet<Event>();

        // Constructor
        public LocalEventsForm()
        {
            InitializeComponent();

            // Set the size of the form
            this.Size = new Size(800, 600);

            // Set the minimum size of the form
            this.MinimumSize = new Size(800, 550);

            // Opening form in the center of the screen
            this.StartPosition = FormStartPosition.CenterScreen;

            // Initialize and load sample events
            LoadEvents();


        }

        // Method to initialize some sample events for demonstration
        private void LoadEvents()
        {
            eventsByDate = new SortedDictionary<DateTime, Queue<Event>>();
            try
            {
                // Existing sample Events
                AddEventToQueue(new Event { Title = "Neighborhood Block Party", Category = "Community & Cultural", Date = new DateTime(2024, 10, 13), Description = "Enjoy food, games, and activities with your neighbors." });
                AddEventToQueue(new Event { Title = "Basketball Tournament", Category = "Sports & Fitness", Date = new DateTime(2024, 11, 07), Description = "Compete in our annual basketball tournament." });
                AddEventToQueue(new Event { Title = "City Council Workshop", Category = "Public Meetings", Date = new DateTime(2024, 12, 03), Description = "Participate in discussions about community issues." });
                AddEventToQueue(new Event { Title = "Winter Music Gala", Category = "Arts & Performance", Date = new DateTime(2024, 12, 15), Description = "Enjoy an evening of music performances from local artists." });
                AddEventToQueue(new Event { Title = "Photography Showcase", Category = "Arts & Performance", Date = new DateTime(2024, 11, 18), Description = "Exhibit featuring stunning local photography." });
                AddEventToQueue(new Event { Title = "Charity Fun Run", Category = "Sports & Fitness", Date = new DateTime(2024, 10, 22), Description = "Join us for a fun run to raise money for local charities." });
                AddEventToQueue(new Event { Title = "Craft Fair", Category = "Local Business & Markets", Date = new DateTime(2024, 10, 27), Description = "Support local artisans at our craft fair." });
                AddEventToQueue(new Event { Title = "Coding Bootcamp", Category = "Education & Workshops", Date = new DateTime(2024, 11, 28), Description = "Learn coding skills in this hands-on workshop." });
                AddEventToQueue(new Event { Title = "Community Garden Workshop", Category = "Environmental & Outdoors", Date = new DateTime(2024, 10, 30), Description = "Learn how to create and maintain a community garden." });
                AddEventToQueue(new Event { Title = "Local History Lecture", Category = "Education & Workshops", Date = new DateTime(2024, 11, 12), Description = "Discover the rich history of our town." });
                AddEventToQueue(new Event { Title = "Holiday Craft Workshop", Category = "Arts & Performance", Date = new DateTime(2024, 12, 05), Description = "Create holiday decorations and gifts." });
                AddEventToQueue(new Event { Title = "Outdoor Movie Night", Category = "Community & Cultural", Date = new DateTime(2024, 11, 25), Description = "Join us for a movie under the stars." });
                AddEventToQueue(new Event { Title = "Poetry Slam", Category = "Arts & Performance", Date = new DateTime(2024, 11, 29), Description = "Showcase your poetic talent or enjoy local poets." });
                AddEventToQueue(new Event { Title = "Science Fair", Category = "Education & Workshops", Date = new DateTime(2024, 12, 20), Description = "Discover innovative projects from local students." });
                AddEventToQueue(new Event { Title = "Baking Competition", Category = "Community & Cultural", Date = new DateTime(2024, 11, 10), Description = "Show off your baking skills and compete for prizes." });
                AddEventToQueue(new Event { Title = "Fitness Bootcamp", Category = "Sports & Fitness", Date = new DateTime(2024, 10, 18), Description = "Join us for a morning of fitness challenges." });
                AddEventToQueue(new Event { Title = "Holiday Lights Parade", Category = "Community & Cultural", Date = new DateTime(2024, 12, 15), Description = "Celebrate the season with a festive parade." });
                AddEventToQueue(new Event { Title = "Local Business Expo", Category = "Local Business & Markets", Date = new DateTime(2024, 11, 22), Description = "Support local businesses and discover new products." });
                AddEventToQueue(new Event { Title = "Dance Night", Category = "Arts & Performance", Date = new DateTime(2024, 11, 17), Description = "Join us for a night of dancing and fun!" });
                AddEventToQueue(new Event { Title = "Sustainable Living Workshop", Category = "Education & Workshops", Date = new DateTime(2024, 10, 14), Description = "Learn how to live more sustainably in your community." });
                AddEventToQueue(new Event { Title = "Pet Adoption Fair", Category = "Local Business & Markets", Date = new DateTime(2024, 10, 28), Description = "Find your new furry friend at our adoption fair." });
                AddEventToQueue(new Event { Title = "Spring Fashion Show", Category = "Arts & Performance", Date = new DateTime(2024, 12, 02), Description = "Showcasing the latest spring trends from local designers." });
                AddEventToQueue(new Event { Title = "Open Mic Night", Category = "Arts & Performance", Date = new DateTime(2024, 11, 23), Description = "Showcase your talent or enjoy local performers." });
                AddEventToQueue(new Event { Title = "Volunteer Day", Category = "Community & Cultural", Date = new DateTime(2024, 10, 19), Description = "Join us for a day of community service." });
                AddEventToQueue(new Event { Title = "Kids’ Art Camp", Category = "Education & Workshops", Date = new DateTime(2024, 11, 04), Description = "A creative camp for kids to explore art." });
                AddEventToQueue(new Event { Title = "Heritage Festival", Category = "Community & Cultural", Date = new DateTime(2024, 11, 11), Description = "Celebrate diverse cultures through food, music, and activities." });

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading events: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PopulateCategoryComboBox();
        }
        //Adapted from StackOverflow
        //Bennett, G. (2024). Binding a WPF ComboBox to a custom list. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/561166/binding-a-wpf-combobox-to-a-custom-list [Accessed 10 Oct. 2024].
        //https://stackoverflow.com/users/35377/geoff-bennett

        // Method to bind hash set eventCategories to category combobox
        private void PopulateCategoryComboBox()
        {
            cmbCategoryPick.Items.Clear();
            cmbCategoryPick.Items.Add("All"); // Add default "All" option
            foreach (var category in eventCategories)
            {
                cmbCategoryPick.Items.Add(category);
            }

            //Shane (2024). Setting SelectedIndex to 0 for DropDown with AutoPostBack set to true. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/54470093/setting-selectedindex-to-0-for-dropdown-with-autopostback-set-to-true [Accessed 10 Oct. 2024].
            //https://stackoverflow.com/users/5971071/shane

            cmbCategoryPick.SelectedIndex = 0; // Set default selection
        }

        // Adds event to the SortedDictionary as a priority queue (by date)
        private void AddEventToQueue(Event ev)
        {
            if (!eventsByDate.ContainsKey(ev.Date))
            {
                eventsByDate[ev.Date] = new Queue<Event>();
            }
            eventsByDate[ev.Date].Enqueue(ev);

            // Add category to HashSet to ensure uniqueness
            eventCategories.Add(ev.Category);
        }

        // Event handler for Search button click
        private void btnSearchEvents_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtbSearchEvents.Text.Trim().ToLower();
                string selectedCategory = cmbCategoryPick.SelectedItem?.ToString() ?? "All";
                DateTime fromDate = dtpFrom.Value;
                DateTime toDate = dtpTo.Value;

                // Validate the date range
                if (fromDate > toDate)
                {
                    MessageBox.Show("Please ensure that the 'From' date is earlier than the 'To' date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                rtbEvents.Clear();
                displayedEvents.Clear();

                foreach (var date in eventsByDate.Keys)
                {
                    if (date >= fromDate && date <= toDate)
                    {
                        foreach (var ev in eventsByDate[date])
                        {
                            if ((string.IsNullOrEmpty(searchTerm) || ev.Title.ToLower().Contains(searchTerm)) &&
                                (selectedCategory == "All" || ev.Category == selectedCategory))
                            {
                                AppendEventToRichTextBox(ev);
                                displayedEvents.Add(ev);
                            }
                        }
                    }
                }

                if (rtbEvents.Text == string.Empty)
                {
                    rtbEvents.AppendText("No events found.\n");
                }

                UpdateSearchHistory(searchTerm);
                ShowRecommendations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during the search: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ElektroStudios (2024). Fastest way to append text to a richtextbox? [online] Stack Overflow. Available at: https://stackoverflow.com/questions/16703901/fastest-way-to-append-text-to-a-richtextbox [Accessed 10 Oct. 2024].
        //https://stackoverflow.com/users/4480932/cordell

        // Appends the details of an event to the RichTextBox in a formatted manner
        private void AppendEventToRichTextBox(Event ev, string searchTerm = "")
        {
            rtbEvents.SelectionStart = rtbEvents.TextLength;
            rtbEvents.SelectionLength = 0;
            rtbEvents.SelectionColor = Color.Black; // Default color

            // Append event details
            rtbEvents.AppendText($"{ev.Date.ToShortDateString()}\n");

            if (!string.IsNullOrEmpty(searchTerm) && ev.Title.ToLower().Contains(searchTerm.ToLower()))
            {
                // Highlight the matched term
                int startIndex = ev.Title.ToLower().IndexOf(searchTerm.ToLower());
                rtbEvents.AppendText(ev.Title.Substring(0, startIndex));

                rtbEvents.SelectionColor = Color.Red; // Highlight color
                rtbEvents.AppendText(ev.Title.Substring(startIndex, searchTerm.Length));

                rtbEvents.SelectionColor = Color.Black; // Reset to default
                rtbEvents.AppendText(ev.Title.Substring(startIndex + searchTerm.Length));
            }
            else
            {
                rtbEvents.AppendText($"{ev.Title}");
            }

            rtbEvents.AppendText($" ({ev.Category})\n");
            rtbEvents.AppendText($"{ev.Description}\n");
            rtbEvents.AppendText("------------------------------\n");
        }

        private void UpdateSearchHistory(string searchTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm) && !searchHistory.Contains(searchTerm))
            {
                if (searchHistory.Count >= 10)
                {
                    searchHistory.Dequeue();
                }
                searchHistory.Enqueue(searchTerm);
            }
        }

        // A list of events that are recommended based on the user's search history
        //Additional Recommendation Feature: The RecommendEvents method analyzes user search history stored in the searchHistory queue to suggest related events based on the search terms.
        //
        private List<Event> RecommendEvents()
        {
            var recommendationSet = new HashSet<Event>();
            foreach (var term in searchHistory)
            {
                foreach (var eventsQueue in eventsByDate.Values)
                {
                    foreach (var ev in eventsQueue)
                    {
                        if (ev.Title.ToLower().Contains(term) && !displayedEvents.Contains(ev))
                        {
                            recommendationSet.Add(ev);
                        }
                    }
                }
            }
            return recommendationSet.ToList();
        }
        //Events are recommended based on matching titles and are presented in a user-friendly manner within the RichTextBox via the ShowRecommendations method.
        private void ShowRecommendations()
        {
            if (searchHistory.Count == 0)
            {
                rtbEvents.AppendText("\n\nNo search history available for recommendations.\n");
                return;
            }
            var recommendations = RecommendEvents();

            if (recommendations.Count > 0)
            {
                rtbEvents.AppendText("\n\n----- Recommended Events -----\n");
                foreach (var ev in recommendations)
                {
                    AppendEventToRichTextBox(ev);
                }
            }
            else
            {
                rtbEvents.AppendText("\n\nNo recommendations found.\n");
            }
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        // Class representing a local event with various properties
        private class Event
        {
            // Title of the event
            public string Title { get; set; }

            // Category of the event, e.g., "Sports", "Cultural"
            public string Category { get; set; }

            // Date of the event
            public DateTime Date { get; set; }

            // Brief description of the event
            public string Description { get; set; }

            // Check if two events are equal based on title, category, and date
            public override bool Equals(object obj)
            {
                if (obj is Event otherEvent)
                {
                    return Title == otherEvent.Title && Category == otherEvent.Category && Date == otherEvent.Date;
                }
                return false;
            }

            //Mikejo5000 (2024). Generate C# Equals and GetHashCode Method Overrides - Visual Studio (Windows). [online] Microsoft.com. Available at: https://learn.microsoft.com/en-us/visualstudio/ide/reference/generate-equals-gethashcode-methods?view=vs-2022 [Accessed 10 Oct. 2024].

            // Generate a unique hash code for the event based on title, category, and date
            public override int GetHashCode()
            {
                return Title.GetHashCode() ^ Category.GetHashCode() ^ Date.GetHashCode();
            }
        }

        private void LocalEventsForm_Load(object sender, EventArgs e)
        {

            //dotnet-bot (2024). DateTimePicker.MinDate Property (System.Windows.Forms). [online] Microsoft.com. Available at: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.datetimepicker.mindate?view=windowsdesktop-8.0 [Accessed 10 Oct. 2024].

            DateTime today = DateTime.Today;
            dtpFrom.MinDate = today; // Prevent selecting past dates for 'From'
            dtpTo.MinDate = today;   // Prevent selecting past dates for 'To'


        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            // Update the minimum selectable date for dtpTo
            dtpTo.MinDate = dtpFrom.Value;

            // Optional: Automatically set dtpTo to dtpFrom if it’s before dtpTo
            if (dtpTo.Value < dtpFrom.Value)
            {
                dtpTo.Value = dtpFrom.Value; // For valid selections
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {

            //Vbforums.com. (2024). DatePicker MaxDate-VBForums. [online] Available at: https://www.vbforums.com/showthread.php?747743-DatePicker-MaxDate [Accessed 10 Oct. 2024].

            // Update the maximum selectable date for dtpFrom
            dtpFrom.MaxDate = dtpTo.Value;

            // Optional: Automatically set dtpFrom to dtpTo if it’s after dtpFrom
            if (dtpFrom.Value > dtpTo.Value)
            {
                dtpFrom.Value = dtpTo.Value; // For valid selections
            }
        }

        private void LocalEventsForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
