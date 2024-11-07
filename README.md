Practice - JWT
Creating an Authentication System with JWT
Follow these steps to create an authentication system using JWT (JSON Web Token).

1. Creating the User Model
Create a User class with the following properties:

Id (int, primary key)
Email (string, unique)
Password (string)
2. Database Setup
Using Entity Framework, create a DbContext class and add the User model you defined above to this context.

3. JWT Creation
Perform the following steps:

Create an AuthController class.
Write a Login method to verify the user's identity. This method should accept Email and Password as inputs and generate a valid JWT for the user if authentication is successful.
The generated JWT should be returned to the user.
4. JWT Validation
Set up the necessary configurations to validate the JWT with each request. Use the Authorize attribute to require JWT authentication for specific requests.
