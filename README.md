
# Municipal Services App

## Table of Contents

1. [Introduction](#introduction)  
2. [Features](#features)  
   - 2.1 [Report Issues Page](#report-issues-page)  
   - 2.2 [Local Events and Announcements](#local-events-and-announcements)  
   - 2.3 [Service Request Status](#service-request-status)  
3. [Installation](#installation)  
   - 3.1 [Prerequisites](#prerequisites)  
   - 3.2 [Step-by-Step Installation Instructions](#step-by-step-installation-instructions)  
4. [Usage](#usage)  
   - 4.1 [Reports Page](#reports-page)  
   - 4.2 [Events Page](#events-page)  
5. [Data Structures](#data-structures)  
   - 5.1 [Part 2 Data Structures](#part-2-data-structures)  
   - 5.2 [Part 3 Data Structures Implementation](#part-3-data-structures)  
6. [Conclusion](#conclusion)  

---

## Introduction

The **Municipal Services Application** is a C# .NET Framework-based tool designed to improve municipal service delivery in South Africa. It allows residents to report issues, track service requests, and stay informed about local events and announcements. This guide provides step-by-step instructions on compiling, running, and using the app, making it accessible even for users with limited technical expertise.

---

## Features

### 2.1 Report Issues Page
Users can report issues with municipal services like streetlight malfunctions, potholes, and sanitation problems.

- **Location Input:** Users can enter the specific location of the issue.
- **Category Selection:** A dropdown allows users to choose the category of the issue (e.g., Sanitation, Roads, Utilities).
- **Description Box:** A rich text field for detailed descriptions of the issue.
- **Media Attachment:** Users can attach images or documents to support their reports.
- **Progress Feedback:** Dynamic features like progress bars or encouraging messages provide real-time feedback during submission.

### 2.2 Local Events and Announcements
Stay informed about upcoming events and local announcements.

- **Event Search:** Search events by category, date range, and keyword.
- **Event List:** Events are displayed in a clear, organized format using a `RichTextBox`.
- **Event Recommendations:** Based on user search history, the app recommends relevant events.

### 2.3 Service Request Status (Implemented)
This feature allows users to track the status of their reported issues in real-time.

- **Service Request List:** A well-organized list of all submitted service requests, sorted by unique identifiers (Request IDs).
- **Track Progress:** Users can check the progress of their service requests based on status updates.
- **Efficient Data Management:** Advanced data structures like AVL Trees, Red-Black Trees, and Heaps manage and display request information efficiently.

---

## Installation

### 3.1 Prerequisites
Ensure the following software is installed before you proceed:

- **Microsoft Visual Studio** (2019 or later)  
  - Available for download from [Visual Studio Downloads](https://visualstudio.microsoft.com/downloads/).
- **.NET Framework** version 4.8 or later (usually bundled with Visual Studio).

### 3.2 Step-by-Step Installation Instructions

1. **Download the Source Code:**
   - Clone the repository from [GitHub](https://github.com/ST10029788/PROG7312_MunicipalServicesApp.git) or download it as a zip file.
2. **Open the Solution:**
   - Launch Visual Studio and open the `.sln` file from the downloaded source code directory.
3. **Build the Solution:**
   - In Visual Studio, go to the `Build` menu and select `Build Solution` (or press `Ctrl+Shift+B`).
   - Resolve any build errors if they occur.
4. **Run the Application:**
   - Press `F5` or click the Start button to launch the application.

---

## Usage

### 4.1 Reports Page
This page allows users to submit service issue reports.

- **Location Input:** Enter the location of the issue.
- **Category Selection:** Choose the issue category (e.g., Sanitation, Roads).
- **Description Box:** Provide a detailed description of the problem.
- **Media Attachment:** Attach relevant images or documents.
- **Submit Button:** Finalize and submit the report.

After submission, users can track the status of their reports via the Service Request Status page.

### 4.2 Events Page
Here users can find local events and announcements.

1. **Search Events:**
   - Enter search terms, select a category, and specify a date range.
   - Click **Search** to filter the event list.
2. **View Results:**
   - Events are displayed with their title, category, date, and description.
   - If no events match the criteria, a message indicates no results found.
3. **Event Recommendations:** After each search, the app suggests related events based on past searches.
4. **Navigation:** Return to the main menu by clicking **Back to Main Menu**.

---

## Data Structures

### 5.1 Part 2 Data Structures

- **SortedDictionary<DateTime, Queue<Event>>:** Efficiently organizes events by date, allowing quick retrieval of upcoming events.
- **HashSet<string>:** Ensures unique event categories without duplicates.
- **Queue<string>:** Tracks the user's search history to suggest relevant events.
- **HashSet<Event>:** Prevents duplicate event entries in the recommended list.

### 5.2 Part 3 Data Structures

Here is the expanded section for **Part 3 Data Structures** with additional information on the AVL Tree, Red-Black Tree, Min-Heap, Graph, and Priority Queue, reflecting how each structure is utilized in the **MunicipalServicesApp**. This version includes more detailed explanations of their purpose, usage, benefits, and how they contribute to the overall application.

---

### Part 3: Data Structures

The **MunicipalServicesApp** leverages a variety of advanced data structures to efficiently manage and display service request information. These structures are key to ensuring optimal performance when handling complex tasks like sorting, prioritizing, and managing interdependent service requests. Below is a detailed explanation of each data structure implemented:

---

#### **AVL Tree**

- **Purpose:**  
  The **AVL tree** is a self-balancing binary search tree (BST) that maintains a sorted order of elements, ensuring efficient search, insertion, and deletion operations. It automatically rebalances itself to maintain optimal performance, even with frequent updates.

- **Usage in the App:**  
  In the **MunicipalServicesApp**, the AVL tree stores instances of `ServiceRequest`, enabling efficient, ordered retrieval based on the `RequestId`. When new service requests are submitted, they are inserted into the AVL tree, which ensures that the data is always kept in sorted order. This structure supports efficient searching for specific service requests and allows for quick insertion and deletion when requests are updated or resolved.

- **Benefits:**
  - **Height-Balanced:** The AVL tree ensures that the height difference between the left and right subtrees is at most one. This balance ensures O(log n) time complexity for search, insert, and delete operations. This is especially useful when the service request data set is large and requires frequent updates.
  - **In-Order Traversal:** The AVL tree supports in-order traversal, which returns elements in sorted order. This makes it easy to display service requests in ascending order of their `RequestId`, providing a user-friendly way to track and manage requests.

---

#### **Red-Black Tree**

- **Purpose:**  
  The **Red-Black tree** is another self-balancing binary search tree, similar to the AVL tree, but with different balancing properties. It provides efficient searching and insertion capabilities while maintaining a balanced structure, ensuring that all operations occur in O(log n) time.

- **Usage in the App:**  
  The **Red-Black tree** serves as an alternative to the AVL tree for storing and managing `ServiceRequest` instances. This provides flexibility in terms of balancing strategies, allowing the application to use different balanced trees based on specific use cases, such as when performance is a critical factor and frequent updates to the dataset are necessary.

- **Benefits:**
  - **Balanced Structure:** Red-Black trees use color properties to ensure balance, which guarantees that all insertions and deletions maintain O(log n) time complexity. This is particularly useful when service request data is continuously updated, and the system needs to maintain fast access and modification speeds.
  - **Performance Comparison:** By implementing both AVL and Red-Black trees, the application allows for performance comparison under different scenarios. Developers can benchmark both trees and decide which one offers the best performance for their needs based on factors like the frequency of updates or queries.

---

#### **Min-Heap**

- **Purpose:**  
  The **Min-Heap** is a complete binary tree that maintains the heap property, where the parent node is always less than or equal to its children. This structure is particularly useful for prioritizing elements based on specific criteria, such as urgency or priority.

- **Usage in the App:**  
  In the **MunicipalServicesApp**, the Min-Heap is employed to manage service requests based on their priority. For example, requests with higher urgency or those submitted earlier may be given higher priority for resolution. When a service request is added to the heap, the system can efficiently access the highest priority request.

- **Benefits:**
  - **Priority Management:** The Min-Heap allows for O(log n) time complexity for both insertions and extractions, ensuring that the application can efficiently manage and prioritize service requests with varying levels of urgency. This ensures timely processing of critical service requests, which is essential for efficient municipal service management.
  - **Quick Access to Minimum Element:** By maintaining the heap property, the Min-Heap enables fast retrieval of the request with the highest priority (i.e., the smallest element), improving the responsiveness of the application when handling urgent requests.

---

#### **Graph**

- **Purpose:**  
  The **Graph** data structure is used to represent relationships and dependencies between service requests. It models complex relationships where one service request may affect or depend on the completion of another, helping to understand how tasks or requests are interconnected.

- **Usage in the App:**  
  In the **MunicipalServicesApp**, the graph is used to represent `ServiceRequest` instances as nodes, with edges denoting dependencies between them. For instance, one request (e.g., repairing a water pipe) may depend on another (e.g., excavation work), and the graph helps track these relationships to ensure the correct order of service delivery.

- **Benefits:**
  - **Flexible Relationship Management:** The graph supports operations like traversals (e.g., Breadth-First Search or Depth-First Search) and pathfinding, which are useful for understanding how service requests interact with each other. This is essential when managing large, interconnected systems, such as municipal infrastructure.
  - **Support for Algorithms:** The graph structure enables the use of algorithms like **Prim's Minimum Spanning Tree (MST)** to compute the most efficient way to address interconnected service requests. This can optimize resource allocation and scheduling, ensuring that the most critical requests are resolved first and that dependencies are handled in the correct order.

---

#### **Priority Queue**

- **Purpose:**  
  The **Priority Queue** is a specialized data structure that allows for the processing of elements based on their priority rather than their insertion order. It is particularly useful in scenarios where dynamic selection of elements is required, such as in graph algorithms or task scheduling.

- **Usage in the App:**  
  In the context of the **MunicipalServicesApp**, the **Priority Queue** is utilized during the execution of **Prim's MST algorithm** to manage edges in a graph based on their weights or costs (e.g., urgency, resources required). The priority queue helps select the most critical service request dependencies, ensuring that the application processes the most important tasks first.

- **Benefits:**
  - **Efficient Edge Selection:** The Priority Queue ensures that edges are processed in the correct order by maintaining O(log n) time complexity for both insertions and removals. This is crucial for algorithms that involve dynamically changing data, such as MST, where the edges' priorities (or costs) may change during execution.
  - **Dynamic Management:** The priority queue enables the application to adapt to changing conditions, such as varying service request priorities. For example, if a new, more urgent request is submitted, the priority queue ensures it is handled promptly without disrupting the entire process.

---

### **Conclusion**

The **MunicipalServicesApp** integrates a combination of advanced data structures—**AVL Trees, Red-Black Trees, Min-Heaps, Graphs,** and **Priority Queues**—to create a robust and efficient framework for managing service requests. Each data structure was selected based on its strengths in handling specific operations like sorting, prioritizing, and managing complex relationships. The AVL and Red-Black trees ensure efficient search and update operations, while the Min-Heap and Priority Queue enable responsive, priority-driven service request management. The graph provides a flexible and scalable solution for modeling dependencies and optimizing service resolution paths.

By utilizing these data structures, the application can handle a large volume of service requests, respond promptly to critical issues, and ensure that all dependencies are managed efficiently. This framework also lays the groundwork for future scalability, ensuring that the system can grow to meet the increasing demands of municipal service management.

