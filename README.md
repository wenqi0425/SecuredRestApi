# SecuredRestApi
In order to understand JWT, I do this exercise. 
This is my first REST api project with JWT. 

The requirements:
1) Register as a new user (email, username, password, firstname, last name)
2) Save the data into database
3) When a user input email and password to login, the system will generate a token for the user.
4) The token should be dynamic changed.

The code structure design and steps:

Authentication: register, confirming identity by JWT

// JWT setting
1) JWT.cs mapping with appsettings.json/JWT
2) services.Configure<JWT> / services.AddAuthentication

// user model
3) Models/ApplicationUser.cs inherit from IdentityUser

// prepare database connection
4) DbContext and connection string
5) services.AddDbContext

// default user for test 
6) Authorization.cs to define the user roles: Administrator, Moderator, User
7) create a default user with given constant value to test the database
8) adding service in to Program.cs. 
Once the application first run, the default data will be posted to the database, if these data doesn’t exists.
9) services.AddIdentity / services.AddScoped

// Service to contain core user functions: register / generate JWT / Role... 
10) Services/IUserService.cs
11) Services/UserService.cs

// UserController
12) UserController : ControllerBase

// migration
13) database migration: 
Show defaule user and default roles in the database

// register 
14) RegisterModel.cs
15) add register function to IUserService.cs
16) add register function to UserService 
17) add register function to UserController
18) postman test

// Generate JWT for authentication
19) to request token: 
TokenRequestModel.cs: Email / Password 
20) to generate and return token: 
AuthenticationModel: message, IsAuthenticated, username, email, roles, Token
21) add token function to IUserService.cs
22) add token function to UserService 
23) add token function to UserController
24) postman test
Authentication is done

Authorization part: verifying user, display different content according to user role
// SecuredController
25) SecuredController : ControllerBase
If the user is authenticated, it will show the secured data. 
26) postman test

// Adding Roles to User
27) AddRoleModel.cs
28) add role function to IUserService.cs
29) add role function to UserService 
30) add role function to UserController
31) postman test






















