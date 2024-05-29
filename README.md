Main Method:
------------
This is the entry point of your application. It creates a WebApplication instance using the CreateBuilder method, which sets up the application's services and configuration.

Services Configuration:
----------------------
AddControllers(): Registers the controllers for handling HTTP requests.

AddEndpointsApiExplorer(): Adds support for API exploration and documentation.

AddSwaggerGen(): Registers the Swagger generator, which will create the Swagger JSON file describing your API.

AddScoped<IBookRepository, BookRepository>(): Registers the IBookRepository interface with the BookRepository implementation. This allows you to use dependency injection to access the repository in your controllers.

AddDbContext<BookContext>(...): Configures Entity Framework Core to use an SQLite database named books.db.


Building and Running the Application:
-------------------------------------
Build(): Builds the WebApplication instance.
Run(): Starts the application.

Pipeline Configuration:
-----------------------
UseSwagger() and UseSwaggerUI(): Enable the Swagger UI and JSON endpoint for API documentation. This is only enabled in the development environment (IsDevelopment()).

UseHttpsRedirection(): Redirects HTTP requests to HTTPS.

UseAuthorization(): Adds authorization middleware to the pipeline.

MapControllers(): Maps the controllers to routes in the application.
