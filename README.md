# Samba Active Directory Users Management Tool

Samba Active Directory User Management Tool is a web application built using C# and ASP.NET Blazor Server framework. It allows system and network administrators to manage users in an Active Directory domain emulated by Samba4 on a Linux server. The tool provides a user-friendly web interface that can be accessed by any user with adminstrative privileges over the domain.

## Features

- Add, edit and delete users in the Active Directory domain.
- Change user password.
- Enable and disable user accounts.
- Assign and remove user roles.
- Search for users by username, email, or common name.

## Getting Started

### Prerequisites

To run the Samba Active Directory User Management Tool, you will need:
- A Linux server running Samba 4 and configured as an Active Directory domain controller.
- .NET 6.0 or later installed on the server.
- A web browser that supports Blazor (anything recent should do).

### Installation

1. Clone ths repository to your server:
```
git clone https.//<put-repo-address>/<username>/samba-ad-tool
```

2. Navigate to the cloned repository:
```
cd samba-ad-tool
```

3. Build the project:
```
dotnet build
```

4. Run the project:
```
dotnet run
```

5. Access the tool in your web browser at http://<server-address>:5000

## Usage
The Samba Active Directory User Management Tool provides a user-friendly web interface to manage users in an Active Directory domain. Once you have accessed the tool in your web browser, you can perform the following actions:

- Add a new user: Click on the "Add User" button to open the form to add a new user. Enter the required information and click on "Save".
- Edit a user: Click on the "Edit" button next to a user's name to open the form to edit the user's information. Make the desired changes and click on "Save".
- Delete a user: Click on the "Delete" button next to a user's name to delete the user from the domain.
- Change a user's password: Click on the "Change Password" button next to a user's name to open the form to change the user's password. Enter the new password and click on "Save".
- Enable or disable a user account: Click on the "Enable" or "Disable" button next to a user's name to enable or disable the user's account.
- Assign or remove user roles: Click on the "Edit Roles" button next to a user's name to open the form to edit the user's roles. Check or uncheck the roles and click on "Save".
- Search for users: Enter a username or email address in the search bar to find a user in the domain.

## Contributing
Contributions to the Samba Active Directory User Management Tool are welcome. To contribute, follow these steps:

1. Fork the repository.

2. Create a new branch for your changes:
```
git checkout -b <branch-name>
```
3. Make your changes and commit them:
```
git commit -m "<features-message>"
```

4. Push your changes to the fork
```
git push origin <branch-name>
```

5. Open a pull request

## License
This tool is licensed under the MIT License. See `LICENSE` for more information.

