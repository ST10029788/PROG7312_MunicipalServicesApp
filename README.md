
------------

# Municipal Services App

## Table of Contents

1. [Introduction](#introduction)  
2. [Features](#features)  
   - 2.1 [Report Issues Page](#report-issues-page)  
   - 2.2 [Service Request Status](#service-request-status)  
   - 2.3 [Local Events and Announcements](#local-events-and-announcements)  
3. [Installation](#installation)  
   - 3.1 [Prerequisites](#prerequisites)  
   - 3.2 [Step-by-Step Installation Instructions](#step-by-step-installation-instructions)  
4. [Usage](#usage)  
   - 4.1 [Reports Page](#reports-page)  
   - 4.2 [Service Request Status](#service-request-status-page)  
   - 4.3 [Events Page](#events-page)  
5. [Data Structures](#data-structures)  
   - 5.1 [Part 2 Data Structures](#part-2-data-structures)  
   - 5.2 [Part 3 Data Structures Implementation](#part-3-data-structures)  
6. [Conclusion](#conclusion)

------------

## Introduction

The **Municipal Services Application** is a C# .NET Framework-based tool designed to improve municipal service delivery in South Africa. The application allows residents to report issues, track service requests, and stay informed about local events and announcements. This guide provides step-by-step instructions on compiling, running, and using the app, making it accessible even for users with limited technical expertise.

------------


## Features

### 2.1 Report Issues Page

This feature allows users to report issues related to municipal services, such as streetlight malfunctions, potholes, and sanitation problems.

- **Location Input:** Users can enter the specific location of the issue.
- **Category Selection:** A dropdown menu lets users select the issue's category (e.g., Sanitation, Roads, Utilities).
- **Description Box:** A rich text field where users can provide detailed descriptions of the issue.
- **Media Attachment:** Users can attach images or documents to help describe the issue.
- **Progress Feedback:** The app provides real-time feedback, such as progress bars or encouraging messages, during submission.

### 2.2 Service Request Status

The **Service Request Status** feature allows users to track the status of their reported issues in real-time.

- **Viewing Service Requests:** Users can access the service request status page from the main menu. The application will load service requests from a global list defined in the `ReportIssuesForm`.
- **List View:** Service requests are displayed in a ListView with key details, including:
  - **Request ID:** A unique identifier for the service request.
  - **Description:** A brief description of the service request.
  - **Status:** The current status (e.g., Pending, Completed).
  - **Submission Date:** The date the request was submitted.
  
- **Navigating the Application:** To return to the main menu, users can click the "Back to Main Menu" button.
  
- **Error Handling:** If there is an issue with loading or displaying the service requests, an error message will appear using a message box.

- **Data Structures Used:**
  - **Service Request List:** An organized list of service requests, sorted by their Request IDs.
  - **Track Progress:** Users can track progress via status updates.

### 2.3 Local Events and Announcements

Stay informed about upcoming events and local announcements in the municipality.

- **Event Search:** Users can search for events by category, date range, and keywords.
- **Event List:** Events are displayed in a clear, organized format using a `RichTextBox`.
- **Event Recommendations:** Based on previous searches, the app will suggest relevant events.

------------


Certainly! Below is a more detailed version of the **Installation** section with step-by-step instructions and extra clarification for users who may not be familiar with the development environment or the process of setting up the application.

---

## Installation

### 3.1 Prerequisites

Before installing the **Municipal Services App**, ensure the following software is installed and configured on your computer:

- **Microsoft Visual Studio** (2019 or later)
  - Visual Studio is the integrated development environment (IDE) used to build and run the app.
  - **Download Visual Studio**: Go to [Visual Studio Downloads](https://visualstudio.microsoft.com/downloads/) and download the free **Community Edition** or any of the paid versions.
  - **Installation Steps**: When installing Visual Studio, ensure that the following components are selected during the setup:
    - **Desktop development with C#** (this includes the .NET Framework)
    - **.NET desktop development**
    - **C# and Visual Basic**

- **.NET Framework** version 4.8 or later
  - The application is built using the .NET Framework. Version 4.8 or later is typically included with Visual Studio, but if it is not installed, you can download it separately.
  - **Download .NET Framework 4.8**: [Microsoft .NET Framework 4.8](https://dotnet.microsoft.com/download/dotnet-framework)

Once these prerequisites are installed, you can proceed to the next steps.

---

### 3.2 Step-by-Step Installation Instructions

#### 1. **Download the Source Code**

You have two options to download the source code:

- **Clone the repository using Git** (recommended if you plan to make modifications or updates to the source code):
  1. Install **Git** from [Git Downloads](https://git-scm.com/downloads), if you haven't already.
  2. Open a command prompt or Git Bash.
  3. Clone the repository with the following command:
     ```bash
     git clone https://github.com/ST10029788/PROG7312_MunicipalServicesApp.git
     ```
  4. Navigate to the directory where the project is cloned:
     ```bash
     cd PROG7312_MunicipalServicesApp
     ```

- **Download the source as a ZIP file**:
  1. Visit the [GitHub Repository](https://github.com/ST10029788/PROG7312_MunicipalServicesApp).
  2. Click the green **Code** button and select **Download ZIP**.
  3. Extract the ZIP file to a location on your computer where you can easily access it.

#### 2. **Open the Solution in Visual Studio**

1. Launch **Visual Studio**.
2. In Visual Studio, go to the **File** menu and select **Open** > **Project/Solution**.
3. Navigate to the folder where the source code is located (either the cloned Git repository or the extracted ZIP file).
4. Select the **`PROG7312_MunicipalServicesApp.sln`** solution file and click **Open**.

   - The solution file contains all the necessary project settings and configurations for building and running the app.

#### 3. **Build the Solution**

1. Once the solution is opened in Visual Studio, check the **Solution Explorer** on the right side to confirm that the project has been loaded correctly.
2. To build the solution, go to the **Build** menu at the top of Visual Studio and click **Build Solution**. Alternatively, you can press `Ctrl+Shift+B`.
3. Visual Studio will begin compiling the code. This may take a few seconds to several minutes, depending on your computer's performance.
   
   - If the build is successful, you’ll see a message saying “Build succeeded” in the **Output** window at the bottom of Visual Studio.
   - If there are any build errors (e.g., missing dependencies, incorrect references, etc.), they will appear in the **Error List** window. You will need to review and fix these errors. Common issues include missing NuGet packages or incorrect project settings.

   - **To resolve errors**:
     - Ensure that you have installed all necessary Visual Studio components.
     - If there are package-related errors, you can restore NuGet packages by right-clicking on the solution in **Solution Explorer** and selecting **Restore NuGet Packages**.

#### 4. **Run the Application**

Once the solution is successfully built, you can run the application.

1. **Press `F5`** (or click the green **Start** button in the toolbar) to build and run the application.
   
   - Visual Studio will compile the solution and launch the application in **Debug Mode**. The app should now open in a new window, and you will be able to interact with the features, such as reporting issues or checking local events.

2. **Troubleshooting**:
   - If the application does not launch or displays an error, make sure that all prerequisites are installed correctly.
   - Ensure that Visual Studio is set to use the correct version of the .NET Framework. You can check this by right-clicking the project in **Solution Explorer**, selecting **Properties**, and confirming that the **Target Framework** is set to **.NET Framework 4.8** or later.

---

### Additional Notes

- **Updating the Application**:
  If you have cloned the repository using Git, you can keep your local copy updated by running the following command in your project directory:
  ```bash
  git pull origin main
  ```

- **Running without Visual Studio**:
  If you don't have Visual Studio but would still like to run the app, you can build it using the .NET Core CLI or other IDEs. However, **Visual Studio** is the recommended environment for compiling and debugging the app due to its tight integration with the .NET Framework.


------------


## Usage

### 4.1 Reports Page

The Reports Page allows users to submit service issue reports.

- **Location Input:** Users can specify the issue’s location.
- **Category Selection:** Choose the appropriate issue category (e.g., Sanitation, Roads).
- **Description Box:** Provide a detailed description of the problem.
- **Media Attachment:** Attach images or documents to support the report.
- **Submit Button:** Finalize and submit the report.

Once submitted, users can track the status of their report via the Service Request Status page.

### 4.2 Service Request Status Page

- **Viewing Service Requests:** This page displays all the service requests users have made.
- **Request Details:** Requests are listed with details like Request ID, Description, Status, and Submission Date.
- **Tracking Progress:** Users can track updates as the service requests are processed (e.g., Pending, Completed).
- **Back to Menu:** Users can return to the main menu by clicking the "Back to Main Menu" button.

### 4.3 Events Page

On the Events Page, users can explore local events and announcements.

1. **Search Events:**  
   - Input search terms, select a category, and choose a date range to filter events.
   - Click **Search** to display matching results.
   
2. **View Results:**  
   - Events are shown with details like title, category, date, and description.
   - If no events match, a message will indicate no results.

3. **Event Recommendations:** Based on previous searches, the app recommends relevant events.

4. **Navigation:** Users can return to the main menu by clicking **Back to Main Menu**.

------------


## Data Structures

### 5.1 Part 2 Data Structures

- **SortedDictionary<DateTime, Queue<Event>>:** Organizes events by date, enabling quick retrieval of upcoming events.
- **HashSet<string>:** Ensures event categories are unique.
- **Queue<string>:** Tracks user search history for personalized event recommendations.
- **HashSet<Event>:** Prevents duplicate event entries.

### 5.2 Part 3 Data Structures Implementation

In **Part 3**, several advanced data structures are used to optimize the management of service requests:

#### **AVL Tree**

- **Purpose:** A self-balancing binary search tree used for efficient data management.
- **Usage:** Stores `ServiceRequest` instances to keep them sorted by `RequestId`, enabling fast searches, insertions, and deletions.
- **Benefits:** Ensures O(log n) time complexity for search, insert, and delete operations.

#### **Red-Black Tree**

- **Purpose:** Another self-balancing binary search tree with different balancing properties.
- **Usage:** Acts as an alternative to the AVL tree for managing `ServiceRequest` instances.
- **Benefits:** Provides balanced structures for efficient updates and searches, maintaining O(log n) performance.

#### **Min-Heap**

- **Purpose:** A binary tree that prioritizes elements based on specific criteria, like urgency.
- **Usage:** Manages service requests based on their priority. The system can quickly access the highest-priority request.
- **Benefits:** Enables quick retrieval and processing of high-priority requests.

#### **Graph**

- **Purpose:** Models relationships and dependencies between service requests.
- **Usage:** Represents `ServiceRequest` instances as nodes, with edges showing dependencies between tasks (e.g., one service request depends on the completion of another).
- **Benefits:** Supports operations like graph traversal and pathfinding to optimize service request handling.

#### **Priority Queue**

- **Purpose:** A specialized data structure that processes elements based on their priority rather than their insertion order.
- **Usage:** Used during tasks like **Prim’s MST algorithm** to manage edges in a graph based on urgency or resource requirements.
- **Benefits:** Efficiently processes the most critical elements first, ensuring timely resolution of service requests.

------------

## Conclusion

The **MunicipalServicesApp** integrates advanced data structures—**AVL Trees, Red-Black Trees, Min-Heaps, Graphs,** and **Priority Queues**—to optimize the management of service requests. These structures ensure efficient data handling, priority-based management, and effective scheduling of service tasks. The combination of these structures allows the app to efficiently manage large volumes of service requests, respond promptly to urgent issues, and handle interdependencies between requests.

By using these data structures, the **MunicipalServicesApp** provides a scalable and responsive system for managing municipal service requests, which can grow to meet the needs of increasingly complex service environments.

