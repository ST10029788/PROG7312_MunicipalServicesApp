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
    public partial class ServiceRequestStatusForm : Form
    {
        private System.Windows.Forms.TextBox txtFilter; // TextBox for filtering
        private System.Windows.Forms.Button btnFilter; // Button to trigger filtering
        private AVLTree<ServiceRequest> serviceRequestsAVLTree;  // Store service requests in AVL tree
        private RedBlackTree<ServiceRequest> serviceRequestsRedBlackTree;  // Store service requests in Red-Black tree
        private MinHeap<ServiceRequest> serviceRequestsHeap;  // Min-Heap for prioritization
        private Graph<ServiceRequest> serviceRequestGraph;  // Graph for dependencies

        public ServiceRequestStatusForm()
        {
            InitializeComponent();


           
            this.StartPosition = FormStartPosition.CenterScreen;  // Open form centered on screen

            serviceRequestsAVLTree = new AVLTree<ServiceRequest>();  // Initialize AVL tree
            serviceRequestsRedBlackTree = new RedBlackTree<ServiceRequest>();  // Initialize Red-Black tree
            serviceRequestsHeap = new MinHeap<ServiceRequest>();  // Initialize Min-Heap
            serviceRequestGraph = new Graph<ServiceRequest>();  // Initialize Graph

            LoadServiceRequests();  // Load service requests from global list
            DisplayServiceRequests();  // Display service requests in the ListView
        }


        // Method to load service requests from ReportIssuesForm's global list
        private void LoadServiceRequests()
        {
            try
            {
                Console.WriteLine($"Loading {ReportIssuesForm.issueReports.Count} service requests.");

                // Loop through each service request in the global issueReports list
                foreach (var request in ReportIssuesForm.issueReports)
                {
                    // Insert the request into the AVL tree for efficient ordered retrieval
                    serviceRequestsAVLTree.Insert(request);

                    // Insert the request into the Red-Black tree for balanced search operations
                    serviceRequestsRedBlackTree.Insert(request);

                    // Insert the request into the heap for efficient priority management
                    serviceRequestsHeap.Insert(request);

                    // Add the request as a node in the graph for relational data representation
                    serviceRequestGraph.AddNode(request);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if loading requests fails
                MessageBox.Show($"Error loading service requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to display the service requests in a ListView
        private void DisplayServiceRequests()
        {
            try
            {
                // Clear any existing items in the ListView before adding new items
                lstServiceRequests.Items.Clear();

                // Retrieve the service requests in an ordered list using an in-order traversal of the AVL tree
                List<ServiceRequest> avlRequests = serviceRequestsAVLTree.InOrderTraversal();
                Console.WriteLine($"Displaying {avlRequests.Count} service requests.");

                // Loop through each request and create a ListView item to display it
                foreach (var request in avlRequests)
                {
                    // Create a new ListViewItem for the current request
                    ListViewItem item = new ListViewItem(request.RequestId.ToString());

                    // Add subitems for description, status, and submission date
                    item.SubItems.Add(request.Description);
                    item.SubItems.Add(request.Status);
                    item.SubItems.Add(request.SubmissionDate.ToShortDateString());

                    // Add the item to the ListView
                    lstServiceRequests.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                // Show an error message if displaying requests fails
                MessageBox.Show($"Error displaying service requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Event handler for "Back to Main Menu" button click
        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the form and return to the main menu
        }

        private void ServiceRequestStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void lstServiceRequests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterText = txtFilter.Text.ToLower(); // Get the filter text and convert it to lower case
            FilterServiceRequests(filterText);
        }

        private void FilterServiceRequests(string filterText)
        {
            // Clear existing items in the ListView
            lstServiceRequests.Items.Clear();

            // Retrieve the service requests in an ordered list using an in-order traversal of the AVL tree
            List<ServiceRequest> avlRequests = serviceRequestsAVLTree.InOrderTraversal();

            // Loop through each request and check if it matches the filter criteria
            foreach (var request in avlRequests)
            {
                // Check if any of the properties contain the filter text
                if (request.RequestId.ToString().Contains(filterText) ||
                    request.Description.ToLower().Contains(filterText) ||
                    request.Status.ToLower().Contains(filterText) ||
                    request.SubmissionDate.ToShortDateString().Contains(filterText))
                {
                    // Create a new ListViewItem for the current request
                    ListViewItem item = new ListViewItem(request.RequestId.ToString());
                    item.SubItems.Add(request.Description);
                    item.SubItems.Add(request.Status);
                    item.SubItems.Add(request.SubmissionDate.ToShortDateString());

                    // Add the item to the ListView
                    lstServiceRequests.Items.Add(item);
                }
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    // ServiceRequest class to represent individual service requests
    public class ServiceRequest : IComparable<ServiceRequest>
    {
        public int RequestId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime SubmissionDate { get; set; }

        public ServiceRequest(int requestId, string description, string status, DateTime submissionDate)
        {
            RequestId = requestId;
            Description = description;
            Status = status;
            SubmissionDate = submissionDate;
        }

        // Compare ServiceRequest objects by RequestId
        public int CompareTo(ServiceRequest other)
        {
            return this.RequestId.CompareTo(other.RequestId);
        }
    }

    // AVLTree class for storing service requests in a balanced tree
    // Adapted from in (2008). Tree data structure in C#. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/66893/tree-data-structure-in-c-sharp [Accessed 13 Nov. 2024].
    // (in, 2008)
    public class AVLTree<T> where T : IComparable<T>
    {
        private TreeNode<T> root;

        // Insert a new value into the AVL tree
        public void Insert(T value)
        {
            root = InsertRecursive(root, value);
        }

        // Recursive insertion with balancing
        // method adapted from GeeksforGeeks (2012). Insertion in an AVL Tree. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/insertion-in-an-avl-tree/ [Accessed 13 Nov. 2024].
        private TreeNode<T> InsertRecursive(TreeNode<T> node, T value)
        {
            if (node == null)
                return new TreeNode<T>(value);

            int compareResult = value.CompareTo(node.Value);

            if (compareResult < 0)
                node.Left = InsertRecursive(node.Left, value);  // Insert into left subtree
            else if (compareResult > 0)
                node.Right = InsertRecursive(node.Right, value);  // Insert into right subtree

            return Balance(node);  // Balance the tree after insertion
        }

        // Balance the tree after insertions to maintain AVL property
        private TreeNode<T> Balance(TreeNode<T> node)
        {
            int balanceFactor = GetBalanceFactor(node);

            if (balanceFactor > 1) // Left heavy
            {
                if (GetBalanceFactor(node.Left) < 0) // Left-Right Case
                    node.Left = RotateLeft(node.Left);
                node = RotateRight(node);  // Left-Left Case
            }
            else if (balanceFactor < -1) // Right heavy
            {
                if (GetBalanceFactor(node.Right) > 0) // Right-Left Case
                    node.Right = RotateRight(node.Right);
                node = RotateLeft(node);  // Right-Right Case
            }

            return node;
        }
        //Rotation methods adapted from Code (2011). Code with explanation for binary tree rotation (left OR right). [online] Stack Overflow. Available at: https://stackoverflow.com/questions/4597650/code-with-explanation-for-binary-tree-rotation-left-or-right [Accessed 13 Nov. 2024].

        // Rotate nodes to the right
        private TreeNode<T> RotateRight(TreeNode<T> y)
        {
            TreeNode<T> x = y.Left;
            y.Left = x.Right;
            x.Right = y;
            return x;
        }

        // Rotate nodes to the left
        private TreeNode<T> RotateLeft(TreeNode<T> x)
        {
            TreeNode<T> y = x.Right;
            x.Right = y.Left;
            y.Left = x;
            return y;
        }
        //method adapted from Orama.com. (2023). AVL Trees Explained. [online] Available at: https://orama.com/blog/avl-trees-explained [Accessed 13 Nov. 2024].

        // Calculate the balance factor of a node (difference in heights of left and right subtrees)
        private int GetBalanceFactor(TreeNode<T> node)
        {
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        // Calculate the height of a node (longest path to a leaf node)
        private int GetHeight(TreeNode<T> node)
        {
            if (node == null)
                return 0;
            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

        // In-order traversal to retrieve elements in sorted order
        public List<T> InOrderTraversal()
        {
            List<T> result = new List<T>();
            InOrderRecursive(root, result);
            return result;
        }

        // Helper method for in-order traversal
        private void InOrderRecursive(TreeNode<T> node, List<T> result)
        {
            if (node == null)
                return;

            InOrderRecursive(node.Left, result);
            result.Add(node.Value);
            InOrderRecursive(node.Right, result);
        }
    }

    // TreeNode class for storing elements in the AVL tree
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public TreeNode<T> Left { get; set; }
        public TreeNode<T> Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    // MinHeap class for prioritizing elements based on a comparison (e.g., prioritizing based on submission date)
    public class MinHeap<T> where T : IComparable<T>
    {
        private List<T> heap = new List<T>();

        // Insert an element into the heap
        public void Insert(T value)
        {
            heap.Add(value);
            HeapifyUp(heap.Count - 1);  // Maintain heap property
        }

        // Retrieve the minimum element without removing it
        public T Peek()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");
            return heap[0];
        }

        // Remove and return the minimum element
        public T ExtractMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty.");

            T minValue = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);

            return minValue;
        }

        // Get the size of the heap
        public int Size()
        {
            return heap.Count;
        }

        // Heapify up for maintaining heap property after insertion
        private void HeapifyUp(int index)
        {
            if (index == 0) return;  // Reached the root

            int parentIndex = (index - 1) / 2;
            if (heap[index].CompareTo(heap[parentIndex]) < 0)
            {
                Swap(index, parentIndex);
                HeapifyUp(parentIndex);
            }
        }

        // Heapify down for maintaining heap property after extraction
        private void HeapifyDown(int index)
        {
            int smallest = index;
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            if (leftChild < heap.Count && heap[leftChild].CompareTo(heap[smallest]) < 0)
            {
                smallest = leftChild;
            }

            if (rightChild < heap.Count && heap[rightChild].CompareTo(heap[smallest]) < 0)
            {
                smallest = rightChild;
            }

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        // Swap two elements in the heap
        private void Swap(int index1, int index2)
        {
            T temp = heap[index1];
            heap[index1] = heap[index2];
            heap[index2] = temp;
        }
    }

  
    // Graph class for service request dependencies and Minimum Spanning Tree (MST)
    //method partially adapted from list (2012). adjacency list for graph build. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/10740894/adjacency-list-for-graph-build/10741071 [Accessed 13 Nov. 2024].
  
    public class Graph<T>
    {
        private Dictionary<T, List<T>> adjacencyList = new Dictionary<T, List<T>>();

        public void AddNode(T node)
        {
            if (!adjacencyList.ContainsKey(node))
                adjacencyList[node] = new List<T>();
        }

        public void AddEdge(T fromNode, T toNode)
        {
            if (adjacencyList.ContainsKey(fromNode))
                adjacencyList[fromNode].Add(toNode);
        }

        //method adapted from search, B. (2022). Breadth-first search from one node to another. [online] Stack Overflow. Available at: https://stackoverflow.com/questions/71286470/breadth-first-search-from-one-node-to-another [Accessed 13 Nov. 2024].

        public List<T> BreadthFirstSearch(T startNode)
        {
            List<T> result = new List<T>();
            Queue<T> queue = new Queue<T>();
            HashSet<T> visited = new HashSet<T>();

            queue.Enqueue(startNode);
            visited.Add(startNode);

            while (queue.Count > 0)
            {
                T currentNode = queue.Dequeue();
                result.Add(currentNode);

                foreach (T neighbor in adjacencyList[currentNode])
                {
                    if (!visited.Contains(neighbor))
                    {
                        queue.Enqueue(neighbor);
                        visited.Add(neighbor);
                    }
                }
            }

            return result;
        }

        // Implementing Prim's Algorithm to compute Minimum Spanning Tree (MST)
        public List<Tuple<T, T>> MinimumSpanningTree(T startNode)
        {
            List<Tuple<T, T>> mst = new List<Tuple<T, T>>();
            HashSet<T> visited = new HashSet<T>();
            PriorityQueue<Tuple<T, T>> priorityQueue = new PriorityQueue<Tuple<T, T>>();

            visited.Add(startNode);

            // Add all edges from start node to priority queue
            foreach (T neighbor in adjacencyList[startNode])
            {
                priorityQueue.Enqueue(Tuple.Create(startNode, neighbor));
            }

            // Prim's algorithm
            //GeeksforGeeks (2012). Prim’s Algorithm for Minimum Spanning Tree (MST). [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/prims-minimum-spanning-tree-mst-greedy-algo-5/ [Accessed 13 Nov. 2024].

            while (priorityQueue.Count > 0)
            {
                var edge = priorityQueue.Dequeue();

                T nodeA = edge.Item1;
                T nodeB = edge.Item2;

                if (!visited.Contains(nodeB))
                {
                    visited.Add(nodeB);
                    mst.Add(edge);

                    foreach (T neighbor in adjacencyList[nodeB])
                    {
                        if (!visited.Contains(neighbor))
                        {
                            priorityQueue.Enqueue(Tuple.Create(nodeB, neighbor));
                        }
                    }
                }
            }

            return mst;
        }
    }

    //Priority queue class for Prim's MST algorithm
    //method adapted from GeeksforGeeks (2016). Prim’s algorithm using priority_queue in STL. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/prims-algorithm-using-priority_queue-stl/ [Accessed 13 Nov. 2024].

 
    public class PriorityQueue<T>
    {
        private List<T> elements = new List<T>();

        public int Count => elements.Count;

        public void Enqueue(T item)
        {
            elements.Add(item);
        }

        public T Dequeue()
        {
            T item = elements[0];
            elements.RemoveAt(0);
            return item;
        }
    }

    
    // Red black tree class
    //method adapted from Cs.au.dk. (2024). Available at: https://cs.au.dk/~gerth/ads20/code/RedBlackTree.java [Accessed 13 Nov. 2024].
  
    public class RedBlackTree<T> where T : IComparable<T>
    {
        private enum NodeColor { Red, Black } // Enum to represent node colors

        // Inner node class
        private class RedBlackNode
        {
            public T Value;
            public RedBlackNode Left, Right, Parent;
            public NodeColor Color; // Color of the node

            // Node constructor
            public RedBlackNode(T value)
            {
                Value = value;
                Left = Right = Parent = null;
                Color = NodeColor.Red; // New nodes start as red
            }
        }

        private RedBlackNode root;

        // Tree constructor
        public RedBlackTree()
        {
            root = null;
        }

        // Insert a new value into the Red-Black Tree
        public void Insert(T value)
        {
            RedBlackNode newNode = new RedBlackNode(value);
            if (root == null) // If the tree is empty
            {
                root = newNode;
                root.Color = NodeColor.Black; // Root is always black
            }
            else
            {
                RedBlackNode parent = null, current = root;
                while (current != null)
                {
                    parent = current;
                    if (value.CompareTo(current.Value) < 0)
                        current = current.Left;
                    else
                        current = current.Right;
                }

                newNode.Parent = parent;
                if (value.CompareTo(parent.Value) < 0)
                    parent.Left = newNode;
                else
                    parent.Right = newNode;

                FixInsert(newNode); // Ensure tree properties are maintained
            }
        }

        // Fix Red-Black Tree violations after an insertion
        //method adapted from GeeksforGeeks (2014). Introduction to RedBlack Tree. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/introduction-to-red-black-tree/ [Accessed 13 Nov. 2024].
        private void FixInsert(RedBlackNode node)
        {
            while (node != root && node.Parent.Color == NodeColor.Red)
            {
                RedBlackNode grandParent = node.Parent.Parent;
                if (node.Parent == grandParent.Left) // Parent is a left child
                {
                    RedBlackNode uncle = grandParent.Right;
                    if (uncle != null && uncle.Color == NodeColor.Red) // Case 1
                    {
                        node.Parent.Color = NodeColor.Black;
                        uncle.Color = NodeColor.Black;
                        grandParent.Color = NodeColor.Red;
                        node = grandParent;
                    }
                    else
                    {
                        if (node == node.Parent.Right) // Case 2
                        {
                            node = node.Parent;
                            RotateLeft(node);
                        }
                        node.Parent.Color = NodeColor.Black; // Case 3
                        grandParent.Color = NodeColor.Red;
                        RotateRight(grandParent);
                    }
                }
                else // Parent is a right child (mirror case)
                {
                    RedBlackNode uncle = grandParent.Left;
                    if (uncle != null && uncle.Color == NodeColor.Red)
                    {
                        node.Parent.Color = NodeColor.Black;
                        uncle.Color = NodeColor.Black;
                        grandParent.Color = NodeColor.Red;
                        node = grandParent;
                    }
                    else
                    {
                        if (node == node.Parent.Left)
                        {
                            node = node.Parent;
                            RotateRight(node);
                        }
                        node.Parent.Color = NodeColor.Black;
                        grandParent.Color = NodeColor.Red;
                        RotateLeft(grandParent);
                    }
                }
            }
            root.Color = NodeColor.Black; // Root is always black
        }

        // Rotate the node to the left
        private void RotateLeft(RedBlackNode node)
        {
            RedBlackNode temp = node.Right;
            node.Right = temp.Left;
            if (temp.Left != null)
                temp.Left.Parent = node;

            temp.Parent = node.Parent;
            if (node.Parent == null)
                root = temp;
            else if (node == node.Parent.Left)
                node.Parent.Left = temp;
            else
                node.Parent.Right = temp;

            temp.Left = node;
            node.Parent = temp;
        }

        // Rotate the node to the right
        private void RotateRight(RedBlackNode node)
        {
            RedBlackNode temp = node.Left;
            node.Left = temp.Right;
            if (temp.Right != null)
                temp.Right.Parent = node;

            temp.Parent = node.Parent;
            if (node.Parent == null)
                root = temp;
            else if (node == node.Parent.Right)
                node.Parent.Right = temp;
            else
                node.Parent.Left = temp;

            temp.Right = node;
            node.Parent = temp;
        }
        //method adapted from GeeksforGeeks (2023). Inorder Traversal of Binary Tree. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/inorder-traversal-of-binary-tree/ [Accessed 13 Nov. 2024].

        // In-order traversal to retrieve elements in sorted order
        public List<T> InOrderTraversal()
        {
            List<T> result = new List<T>();
            InOrderRecursive(root, result); // Helper method for recursion
            return result;
        }

        private void InOrderRecursive(RedBlackNode node, List<T> result)
        {
            if (node == null) return;
            InOrderRecursive(node.Left, result);
            result.Add(node.Value);
            InOrderRecursive(node.Right, result);
        }
    }
}