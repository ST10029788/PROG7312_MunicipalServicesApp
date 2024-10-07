# MunicipalServicesApp
## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
   - 2.1 Report Issues Page
   - 2.2 Local Events and Announcements (Future Feature)
   - 2.3 Service Request Status (Future Feature)
3. [Installation](#installation)
   - 3.1 Prerequisites
   - 3.2 Step-by-Step Installation Instructions
4. [Usage](#usage)
   - 4.1 Main Menu Overview
   - 4.2 Reporting an Issue
   - 4.3 Engagement Features
   - 4.4 Navigation
## Introduction
The Municipal Services Application is a C# .NET Framework software designed to enhance municipal service delivery in South Africa. This application allows residents to report issues, access local events and announcements, and track service requests. This document provides detailed instructions on how to compile, run, and use the application.  This guide will help you set up and use the app, even if you're new to computers.


## Features
### Part 1: Report Issues Page
**Main Menu:**
- **Main Menu Options:**
  - **Report Issues:** Report problems like broken streetlights or potholes.
  - **Local Events and Announcements:** Future feature for community news and events.
  - **Service Request Status:** Future feature to check the status of your reports.


**Report Issues Page:**

Location Input: Textbox for users to enter the location of the reported issue.

Category Selection: Dropdown or list for users to select the category of the issue (e.g., sanitation, roads, utilities).

Description Box: RichTextBox for users to provide a detailed description of the issue.

Media Attachment: Button to open a file dialog and attach images or documents related to the issue.

Submit Button: Button to finalize and submit the issue report.

Engagement Feature: Dynamic feature such as a label displaying encouraging messages or a ProgressBar indicating reporting progress.

Navigation Buttons: Buttons for users to return to the main menu or navigate between sections.

**Local Events Page:**

Event Organization: Events are organized using a `SortedDictionary<DateTime, Queue<Event>>`, enabling efficient retrieval based on date.

Search Functionality: Users can search for events by title and filter by category and date range.

Unique Categories: The application tracks unique event categories using a `HashSet<string>`, ensuring no duplicates are displayed.
  
Search History: A `Queue<string>` maintains a history of search terms for user convenience and event recommendations.
  
Event Recommendations: The app suggests events based on user search history, helping users discover new activities that align with their interests.

User-Friendly Interface: Events are displayed in a clear format in a `RichTextBox`, making it easy for users to read event details.
  



## Installation
### Prerequisites
Before compiling and running the application, ensure you have the following software installed:
- **A Computer:** Running Windows.
- **Microsoft Visual Studio:** 2019 or later. (you can download the free Community version).
- ## Downloading Visual Studio

To get started with Visual Studio, follow these steps:

1. **Visit the Visual Studio Website**:
   - Go to [Visual Studio Downloads](https://visualstudio.microsoft.com/downloads/).

2. **Choose Your Edition**:
   - Select the edition that best suits your needs:
     - **Community**: Free for individual developers, open-source projects, academic use, and small professional teams.
     - **Professional**: Paid edition with additional features for professional developers.
     - **Enterprise**: Advanced tools and services for large teams and enterprises.

3. **Download the Installer**:
   - Click on the "Download" button for your chosen edition. This will download the Visual Studio Installer to your computer.

4. **Run the Installer**:
   - Open the downloaded installer and follow the prompts to install Visual Studio.

5. **Select Workloads**:
   - During installation, you can choose specific workloads (like ASP.NET, Desktop Development, etc.) based on the type of development you plan to do.

6. **Complete the Installation**:
   - Once you’ve selected the workloads, click "Install." The installer will download the necessary components and complete the setup.

7. **Launch Visual Studio**:
   - After installation, launch Visual Studio from your Start menu or desktop shortcut.

For additional information and detailed guides, visit the [Visual Studio Documentation](https://docs.microsoft.com/en-us/visualstudio/).

- **.NET Framework:** Version 4.8 or later. (this usually comes with Visual Studio).


Compilation Instructions
1. **Download the Source Code:** Ensure you have downloaded the source code for the application from the provided repository:
   - [GitHub Repository](https://github.com/ST10029788/PROG7312_MunicipalServicesApp.git)
   - Alternatively, you can download it as a zip file, unzip it, and open the .sln file in Visual Studio.
  
2. **Open the Solution:**
   - Launch Microsoft Visual Studio.
   - Open the .sln file from the source code directory.

3. **Build the Solution:**
   - Select **Build** from the top menu and click **Build Solution** (or press `Ctrl+Shift+B`).
   - Ensure there are no build errors. If errors occur, review the error list and resolve any issues.

**Open the Solution:**

Launch Microsoft Visual Studio.
Open the .sln file from the source code directory.

**Build the Solution:**

Select Build from the top menu and click Build Solution (or press Ctrl+Shift+B).
Ensure that there are no build errors. If errors occur, review the error list and resolve any issues.
Running the Application

**Start the Application:**

Press F5 or click on the Start button in Visual Studio to run the application.




## Usage
Upon startup, the main menu will be presented with the following options:
Report Issues (available)
Local Events and Announcements (available)
Service Request Status (to be implemented)

As of Part 2, only the report issues page and local events page is available. 

## Usage of the Reports Page

**Reports Page**
On this page, you can fill Out the Report Form:

**Location Input:**
Find the Location Textbox: On the Report Issues page, locate the textbox labeled Location.
Enter Location Details: Type the specific location where the issue has occurred (e.g., street address or neighborhood). This helps in pinpointing where the issue is situated.

**Category Selection:**
Locate the Dropdown or Listbox: Find the dropdown menu or listbox for selecting the issue category.
Choose a Category: Click on the dropdown arrow and select the appropriate category for the issue from options such as Sanitation, Roads, Utilities, etc. This categorization helps in directing the issue to the relevant department.

**Description Box:**
Find the RichTextBox: Locate the RichTextBox where you can provide a detailed description of the issue.
Enter Details: Type a detailed description of the problem you are reporting. Be as specific as possible to help the municipal staff understand and address the issue effectively.

**Media Attachment:**
Locate the Attach Button: Find the button labeled Attach File or similar.
Attach Images/Documents:
Click the Attach File button to open a file dialog window.
Navigate to the location of the image or document you want to attach.
Select the file and click Open to upload it. Attachments can include photos or documents that provide additional context or evidence of the issue.

**Submit the Report:**
Find the Submit Button: Look for the button labeled Submit on the form.
Click the Submit button to finalize and send your issue report.
The application may display a confirmation message or a progress bar indicating that your report is being processed.
Engagement Feature:

**Dynamic Feedback:** Throughout the process, you may see dynamic engagement features like encouraging messages or a progress bar. These features provide feedback on the submission process and encourage active participation.
Navigate Away:

**Return to Main Menu:** If you wish to go back to the main menu or explore other sections of the application, use the Back to Main Menu button or other navigation buttons provided on the page.

**See all Reported Issues:** Click on the See list button to see a history of reported issues.

## Usage of the Events Page

1. **Loading Events**: Upon opening the form, a predefined set of sample events is loaded for demonstration purposes.
   
2. **Searching Events**:
   - Enter a search term in the text box provided.
   - Select a category from the dropdown menu (e.g., "Cultural", "Sports", "All").
   - Specify a date range using the date pickers.
   - Click the **Search** button to filter events based on your criteria.

3. **Viewing Results**:
   - The matching events will be displayed in the `RichTextBox` with their title, category, date, and description.
   - If no events match the search criteria, a message will indicate that no events were found.

4. **Recommendations**:
   - After each search, the app provides event recommendations based on previously searched terms.
   - Recommended events will appear below the search results.

5. **Navigating Back**:
   - Click the **Back to Main Menu** button to close the form and return to the main application menu.

## Data Structure

- **SortedDictionary<DateTime, Queue<Event>>**: Organizes events by date for efficient chronological access.
- **HashSet<string>**: Stores unique event categories.
- **Queue<string>**: Tracks search history to facilitate recommendations.
- **HashSet<Event>**: Keeps track of displayed events to ensure uniqueness in recommendations.

## Example Events

The following are some examples of events that may be displayed:

- **Neighborhood Block Party**
  - **Category**: Cultural
  - **Date**: 2024-10-12
  - **Description**: Enjoy food, games, and activities with your neighbors.

- **Basketball Tournament**
  - **Category**: Sports
  - **Date**: 2024-11-07
  - **Description**: Compete in our annual basketball tournament.

- **City Council Workshop**
  - **Category**: Public Meetings
  - **Date**: 2024-12-03
  - **Description**: Participate in discussions about community issues.


