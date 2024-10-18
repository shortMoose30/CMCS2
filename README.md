The project makes use of a black background for the UI with the rest of the colors contrasting to it to be better at UIX. All the text is in white and bright button colors for actions such as Submit, Approve, and Reject.

Technologies Used
C#: Front-end/back-end language.
XAML: User interface designed in XAML.
Microsoft Visual Studio: IDE used to code this application in.
File Handling: Claims are saved and managed in a text file called claims.txt.
Upload Document: Supporting files are uploaded to the uploads folder.
Features
Create Claim (Lecturer):
Being a lecturer, he can create a claim about his hours, which includes details like Contract ID, Hours Worked, Rate per Hour, and Description. This gets stored as a pending claim and listed for review.

Check Claim (Coordinator/Manager):
Coordinators and Managers can view the claims submitted and approve or reject the same. The status of each claim is updated, and the same can be viewed in an application section known as View Claims.

Document Upload:
Supporting documents for a claim by lecturers can be uploaded in the form of PDFs or Word while submitting a claim. The files are stored in the uploads directory and get tagged to the particular claim.

Navigation:
It allows easy navigation among different sections, such as Submit Claim, View Claims, and Manage Contracts, through buttons along a side panel. Buttons and pages introduce a consistent black background for the interface and white text for better readability.

Project Structure
The project is structured as follows:

MainWindow.xaml / MainWindow.xaml.cs: This contains the dashboard with navigation buttons to different sections of the system.
SubmitClaim.xaml / SubmitClaim.xaml.cs: This is the form page where lecturers can submit claims.
ViewClaims.xaml / ViewClaims.xaml.cs: This would be the page where Coordinators and Managers are supposed to view and process claims.
claims.txt: File into which claims are written along with their statuses.
uploads/: Folder into which uploaded supporting documents are kept.
Installation and Setup


View Submitted Claims:
The submitted claims will be viewed from the View Claims page, where all the submitted claims will appear. Coordinators and managers will approve or reject claims and update the status.

Upload Supporting Documents:
The supporting document, which is stored in the uploads folder, can be attached by the lecturers in charge of submitting the claim in PDF or Word document, etc., format.

Error Handling
The input fields of the system have been validated for ensuring that no field that is being required is left empty. In case, the system will show a validation message.

Known Issues
File Concurrency: There can be some more concurrency issues with a text file for storing claims in case many users update it at the same time. Moving onto a database would solve this problem.
Overwriting of Files: Similarly, uploaded files with the same name overwrite each other. Adding unique identifiers to the filename can avoid this issue.
Future Improvements
Switch to Database: Switching to database-driven applications from file-based storage to provide more scalability and management of data.
Pagination: In case the number of claims increases overwhelmingly, pagination on the View Claims page should be implemented. Roles and Permissions: There will be different user roles like Admin, Lecturer, and Coordinator; each should be taken to different parts of the system.

https://github.com/shortMoose30/CMCS2.git
