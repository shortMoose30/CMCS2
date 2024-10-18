# Contract Monthly Claim System (CMCS)

## Overview

This project is part of the Portfolio of Evidence (PoE) for the **Contract Monthly Claim System (CMCS)**. The CMCS application allows lecturers to submit monthly claims, while Programme Coordinators and Academic Managers can verify and approve or reject those claims. The system is built using **WPF (Windows Presentation Foundation)** in **C#** to provide a user-friendly interface with the following core functionalities:

- **Claim Submission**: Lecturers can submit claims for work hours, including claim details such as contract ID, hours worked, and claim description.
- **Document Upload**: Supporting documents can be uploaded by lecturers while submitting a claim.
- **Claim Review**: Coordinators and managers can view, approve, or reject submitted claims and update the claim status.
- **Navigation Between Pages**: The application has multiple pages, including a dashboard, claim submission page, and claims overview for managers.

## Technologies Used

- **C# (WPF)**: Core programming language used for the logic and UI design.
- **XAML**: For designing the user interface in WPF.
- **Microsoft Visual Studio**: Development environment for the project.
- **File Handling**: Claims and claim statuses are stored in a text file (`claims.txt`).
- **Document Uploads**: Files are saved in an `uploads` folder for document storage.

## Features

### 1. **Claim Submission (Lecturers)**
- **Submit a Claim**: Lecturers can enter details such as contract ID, hours worked, hourly rate, and description of the claim. A date picker allows them to select the claim date.
- **File Upload**: A file upload feature is available to attach supporting documents (e.g., PDF, Word documents).
- **Data Persistence**: Claims are stored in a text file (`claims.txt`) for easy retrieval and management.
  
### 2. **Claim Verification (Coordinators/Managers)**
- **View Submitted Claims**: A list of all submitted claims is displayed, showing contract ID, hours worked, hourly rate, total amount, description, date, and status.
- **Approve/Reject Claims**: Coordinators and managers can approve or reject claims by updating the claim status in the system.
  
### 3. **Document Upload Management**
- **Upload Supporting Documents**: Lecturers can upload supporting documents (e.g., PDFs, DOCX files) when submitting a claim.
- **File Handling**: Uploaded documents are saved in an `uploads` directory and associated with the relevant claim.

### 4. **Navigation**
- **Multi-Page Navigation**: The application has separate pages for different functionalities:
  - **Dashboard**
  - **Submit Claim**
  - **View Claims**
  - **Manage Contracts**
  - **Settings**

  Each page can be accessed through a navigation panel on the left-hand side, allowing easy movement between sections of the app.

## Project Structure

The project follows a well-structured layout, with XAML and code-behind files for each page.


### Key Files:

- **MainWindow.xaml / MainWindow.xaml.cs**: The main dashboard with navigation buttons to different sections.
- **SubmitClaim.xaml / SubmitClaim.xaml.cs**: The page where lecturers submit their claims.
- **ViewClaims.xaml / ViewClaims.xaml.cs**: Displays all submitted claims for coordinators and managers to review and approve/reject.
- **claims.txt**: Stores all the submitted claims and their statuses.
- **uploads/**: Contains uploaded supporting documents.

## Installation & Setup

### Prerequisites:
- **Visual Studio 2019/2022**: Install Visual Studio with support for WPF and .NET.
- **.NET Framework**: Ensure the .NET version for the project is installed (e.g., .NET 5 or later).

### Steps:
1. **Clone the Repository**: Clone the project files to your local machine.
   ```bash
   git clone https://github.com/your-repo/cmcs-system.git


# CMCS2
