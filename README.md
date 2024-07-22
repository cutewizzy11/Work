# Appointment Management System

Appointment Management System is a web application built using Windows Forms, designed to simplify the process of scheduling and managing appointments for businesses or organizations.

## Key Features

- **User Authentication:** Secure login and account creation for administrators and customers, with password recovery functionality.
- **Appointment Management:** Schedule, edit, and delete appointments, with automatic removal of expired appointments and archiving of past appointments.
- **User Roles:** Administrators have full access, while customers have restricted access tailored to their appointment needs.
- **Automated SMS Notifications:** Real-time notifications for appointment actions, with a text file-based log for easy tracking.
- **System Administration:** Comprehensive CRUD functionality for managing users and appointments, with the option to create additional admins.

## Technologies Used

- Windows Forms
- MongoDB
- Automated SMS Notification Integration

## Application Flow

When the app runs, the user is sent to a welcome screen that allows them to select between "I want to login" and "I want to register".

- If the "I want to login" button is clicked, the user is sent to the login screen that has fields for email and password, a login button, and a "You don't have an account? Register here" link to the registration screen.
  
- If the user clicks "I want to register" on the welcome screen, the user is sent to the registration screen that has "client" and "lawyer" selection options. 
  - If the user selects "client", they are presented with a form having fields for First Name, Last Name, Email, Password, and a Register button. 
  - If the user selects the "lawyer" option, they are presented with a form having fields for First Name, Last Name, License Number, Email, Password, and a Register button.

## Functionalities

### For Clients:
- User registration and profile creation.
- Search and filtering options to find lawyers based on expertise, location, ratings, etc.
- Secure messaging system for communication between clients and lawyers.
- Appointment scheduling and calendar integration.
- In-app payments for legal services.
- Ratings and reviews for lawyers.

### For Lawyers:
- Registration and profile setup.
- Notification system for new client inquiries or appointment requests.
- Access to client information and case details.
- In-app billing and payment processing.
- Calendar integration for scheduling appointments.
- Ability to update availability and expertise.
- Document sharing and e-signature capabilities.
- Legal resource library or FAQ section.

### For Admin:
- Push notifications for important updates.
- Integration with legal databases or research tools.
- 3% commission on any in-app payment made from client to lawyer (for booking appointments).

## Additional Notes
- Integration with Paystack for payments.
- Use of a map locator for clients to find the location of a lawyer's establishment on the map.
- Although the initial plan mentioned using XAMPP server, the current setup does not use it.

## How to Run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Ensure you have the necessary packages installed for MongoDB and SMS notification integration.
4. Configure your MongoDB connection string and SMS API credentials in the application settings.
5. Build and run the application.

## License

This project is licensed under the MIT License - see the LICENSE.md file for details.
