# Shopping-System
The system is designed to store information about the date of the order, the store (supermarket), the list of ordered products, and their quantities.
The key functionalities of the application include:

1. **Customer Shopping**:
   - Customers can select a store for purchasing products.
   - Users can choose products from a list with price details.
   - Customers can specify the quantity of products they want to order.

2. **View Orders**:
   - Users have the ability to view a list of their previous orders.
   - When a specific order is selected, the application displays comprehensive information about the products in the order, including quantities, prices, and the total cost.

### Project Tasks

The project is organized into several tasks:

1. **Data Model**:
   - Define classes for Product, Customer, Supermarket, Order, and OrderDetails based on the provided schema. Ensure that the properties align with the schema, including setting appropriate primary keys and navigation properties for foreign keys.

2. **Database Context**:
   - Create a context class named "ShoppingContext" and specify which entities are part of the data model, including Products, Customers, Supermarkets, Orders, and OrderDetails.

3. **Configuration**:
   - Configure the connection service and options for AddDBContext in the Startup.cs (ConfigureServices).

4. **Database Connection**:
   - Add a connection string to the appsettings.json file.

5. **Database Seeding**:
   - Develop a class for seeding the database (SampleData.cs) and define the ServiceProvider in Program.cs.

6. **Building the Application**:
   - Build the application to generate the database, which can be accessed through SQL Server Object Explorer.

7. **Controllers and Views**:
   - Create controllers and views for the Product, Supermarket, and Customer data models using scaffolding. Enhance the Index page by adding navigation bars and links to the relevant index pages of the data models.

8. **Sorting and Filtering**:
   - Implement the capability to sort the list of customers by last name or address, in both ascending and descending order.

9. **Filtering**:
   - Enable users to filter the list of customers by last or first name using a substring in an input field.

10. **Pagination**:
    - Implement pagination for the Supermarkets index page.

11. **Orders Page**:
    - Create an "Orders" page that displays related data as follows:
        - The list of orders displays information from the Customers and Supermarkets entities.
        - When a user selects an order, information from the OrderDetails entity is displayed. This includes showing the actual names of items, such as 'product name' instead of 'productId' and 'supermarket name' instead of 'supermarketId'.

### Project Details

This project serves as a comprehensive exercise in building a database-driven shopping system using Entity Framework Core and ASP.NET Core. It covers various aspects of database modeling, CRUD operations, sorting, filtering, pagination, and more, making it a valuable learning experience for developers.
