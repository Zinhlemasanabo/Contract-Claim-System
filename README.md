# Contract-Claim-System
## Project Overview

The Contract Monthly Claim System (CMCS) is a WPF desktop application designed to streamline the process of submitting, verifying, and approving lecturer claims. The system improves efficiency, transparency, and usability for lecturers, programme coordinators, and academic managers.

This project was developed as part of the PROG6212 module coursework and incorporates lecturer feedback to enhance usability, version control, and project documentation.

## Features

### Lecturer Features

Submit monthly claims with the following details:

Hours worked
Hourly rate
Additional notes
Supporting documents (.pdf, .docx, .xlsx)

The system automatically:

Calculates the total claim amount (Hours × Rate)
Displays a confirmation message after successful submission
Provides real-time claim status updates (Pending, Approved, Rejected)

### Coordinator and Manager Features

View all submitted claims in a structured DataGrid

Approve claims with a single click

Reject claims with a single click

Update claim statuses instantly so lecturers can track progress

### File Upload System

Integrated file picker using OpenFileDialog

Validates supported file types

Restricts file size

Displays the uploaded filename

### Claim Status Tracking

Dynamic status label showing:

Pending
Approved
Rejected

Status updates are reflected immediately.

### Additional Features

Automatic total calculation

Input validation and error handling

User-friendly interface

Designed for future enhancements such as:

Search and filter claims

Export claims to CSV

## Technologies Used

Language: C#
Framework: .NET WPF
IDE: Visual Studio 2022
Design Pattern: MVVM (partial implementation)
Version Control: Git and GitHub

## Project Structure

```text
ContractClaimSystem/
│
├── Models/
│   └── Claim.cs
│
├── Views/
│   ├── MainWindow.xaml
│   └── Verification.xaml
│
├── App.xaml
├── App.xaml.cs
├── MainWindow.xaml.cs
├── Verification.xaml.cs
└── README.md
```

## How to Run the Project

1. Clone the repository

```bash
git clone https://github.com/YourGitHubUsername/ContractClaimSystem.git
```

2. Open the solution in Visual Studio 2022

File → Open → Project/Solution

Select `ContractClaimSystem.sln`

3. Build and run the project

Press `Ctrl + F5` or select **Start Without Debugging**

4. Test the system

Submit a lecturer claim

Upload a supporting document

Approve or reject claims in the verification window

Track claim status updates

## Lecturer Feedback Integration

After receiving feedback on the previous submission, the following improvements were implemented:

Added Work Breakdown Structure (WBS) and Network Diagram placeholders

Improved version control using Git and GitHub commits

Enhanced form validation and error handling

Implemented dynamic claim status tracking

Reorganized code into Models and Views folders

## Learning Reflection

Developing this project strengthened my skills in:

C# and WPF application development

Graphical user interface design

File handling and validation

Role-based workflow simulation

Data validation and user feedback

Version control with Git and GitHub

I enjoyed building this project and watching it evolve from a basic prototype into a functional and professional desktop application.

## Declaration

I declare that this project was developed independently for academic purposes under the PROG6212 module and that all sources used have been properly acknowledged.

## Author

Zinhle Masanabo

## License

This project is intended for educational purposes only.

© 2025 Contract Monthly Claim System. All rights reserved.
