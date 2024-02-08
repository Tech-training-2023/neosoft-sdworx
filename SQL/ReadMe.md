# Installation
- [Installation on Premise](https://go.microsoft.com/fwlink/p/?linkid=2216019&clcid=0x809&culture=en-gb&country=gb)
- [Install Sql Server Management Studio with Azure Data Studio](https://aka.ms/ssmsfullsetup)
- [Adventure Works Database backup file](https://learn.microsoft.com/en-us/sql/samples/adventureworks-install-configure?view=sql-server-ver16&tabs=ssms)
# [SQL](https://www.tutorialspoint.com/sql/sql-overview.htm)
- Structured Query Language - mostly used to query data in relational databases.
- SQL is a Declarative language - Declarative languages enable you to describe the output you want, and leave the details of the steps required to produce the output to the execution engine. While Procedural languages like C, C++ enable you to define a sequence of instructions that the computer follows to perform a task.
- Used to store, manipulate, retrieve/fetch data from RBDMS
- Sql is a standard query language for RDBMS. Eg of RBDMS - mySql, PostGres, Excel, MS Access (JET Sql), Oracle (PL/Sql), Sybase, **Sql Server** (tSql)
* Just a language made to be really good at storing and querying (grabbing data) information from a database
* Now it isn't really a programming langauge (I know confusing) since it lacks basic tools that a normal programming language has
    * Control flow statements? HA non-existent
    * To re-cap, control flow statements are the for loops statements
* It is just a query langauge because it is a language made to get data
* However, down the line, people didn't like this so they created multiple versions of SQL that acts like a proper programming language 
    * Ex: Pl/pgSQL, T-SQL, PL-SQL, etc. (<- you don't need to know the different type of SQL except for T-SQL)
## Database
* It is just an organized collection of data stored in some format
* They allow us to input, manage, organize, and retrieve data quickly
* With most databases, they are organized into tables and each table will have a row and a column
    * Think of a Microsoft Excel sheet
    * Data is the actual intersection between a row and column 
## [Relational Database Management System (RDBMS)](https://www.tutorialspoint.com/sql/sql-rdbms-concepts.htm)
* A more advance form of a database with an even fancier name.
* A relational database is one in which the data has been organized in multiple tables (technically referred to as relations), each representing a particular type of entity (such as a customer, product, or sales order). 
* The attributes of these entities (for example, a customer's name, a product's price, or a sales order's order date) are defined as the columns, or attributes, of the table, and each row in the table represents an instance of the entity type (for example, a specific customer, product, or sales order).
## SQL Sublanguages
* Essentially, people decided to organized what each statement (They decided to call it statements instead of functions so... start thinking they are the same thing) does in our RDBMS
### Data Definition Language (DDL)
- handle database objects (database, tables, stored procedures, functions, schemas)
- Create, alter, drop, truncate
* It is used for the creation/alteration of tables, database object etc...
* CREATE - most commonly used to create tables but you can use it to create database, views, stored procedures, functions, schemas etc....
* ALTER - used to alter/modify existing tables
* TRUNCATE - removes all data in a table, **cannot rollback the changes**
* DROP - removes the table structure from the database or database, stored procedure, schemas, views, functions etc...
## Data Manipulation Langauge (DML)
- Select, Insert, Update, Delete
* It is for changing/manipulating/modifying the data within a table
* INSERT - Adds data(rows) to your table
* SELECT - Retrieves the data from a table for us to read
* UPDATE - Modify/updates the data from a table
    - You can use the where clause to select/filter the data in a table
* DELETE - Deletes a row from a table
    - You can use the where clause to select/filter which data to remove
## DCL
- used for access controls
- Grant, Revoke
## TCL 
- used for transactions
- Commit, savepoint, rollback

## Tables
- Database object which stores data in the form of rows and columns
- Record or rows are the part of the group of related values.
- Columns hold the collection of similar type of fields. Like restaurant name is a column.
- Field the fundamental or smallest unit in the table is a field which can have a value or null.
- null value means no value or left blank. Empty space is not a null value

| Restaurant Name | Location | Reviews |
|-----------------|----------|---------|
| McDonalds       | Delhi    | 4       |
| Mod's           |Virginia  | 4.2     |

- [Activity on SELECT Statements](https://learn.microsoft.com/en-us/training/modules/introduction-to-transact-sql/)
## [Datatypes in Sql](https://www.tutorialspoint.com/sql/sql-data-types.htm)
- Numeric - int, bigint, smallint, bit, decimal, numeric, money, smallmoney, approximate numerics (float, real)
- Date and time - datetime, smalldatetime, date, time
- Non-Unicode Character strings - fixed-length (char), variable length (varchar, varchar(max), text)
    - char - 8000 characters
    - aka single-byte character set supports up to 256 different characters, stored as one byte per character
    - Single-byte character data is indicated with single quotation marks alone—for example 'SQL Server'.
- Unicode Character Strings - fixed length (nchar), variable lengths (nvarchar, nvarchar(max), ntext)
    - nchar - 4000 character
    - aka  multi-byte character set supports more than 65,000 different characters by storing each character as multiple bytes—typically two bytes per character
    - Multi-byte character data is indicated by single quotation marks with the prefix N (for National)— for example N'SQL Server’. The N prefix is always required, even when inserting the data into a column or variable with a multi-byte type. 

- Binary - Binary string data types allow a developer to store binary information, such as serialized files, images, byte streams, and other specialized data.
- uniqueidentifier (guid) - the uniqueidentifier data type allows the generation and storage of globally unique identifiers (GUIDs), stored as a 16-byte value. 
    - Values for the uniqueidentifier data type can be generated within  SQL Server by using the NEWID() system function; they can also be generated by external applications or converted from string values.
- xml - xml data type allows XML nodes and attributes to be queried within a T-SQL query using XQuery expressions. 
        - The xml data type also optionally allows an XML schema to be enforced. Each instance of an xml data type can store up to 2 GB of data. 
-  Miscellaneous - hierarchyid, rowversion, geometry, geography, sql-variant, cursor, table

### Collation
A collation is a collection of properties that determine several aspects of character data, including: 
- Language or locale, from which is derived: 
    -  Character set 
    - Sort order 
- Case sensitivity 
- Accent sensitivity
-  When querying, it is important to be aware of the collation settings for your character data—for example, whether it is case-sensitive. 
- The following query will return different results, depending on whether the column being tested in the WHERE clause is case-sensitive or not: 
- If the column is case-sensitive, this query will return results. Note that the case of the search term matches the case of the data as stored in the database: 
- **Case-Sensitivity Example (1)**
```
select customerid, lastname 
from SalesLT.Customer 
WHERE lastname = N'Caprio';
```
- Amending the search term, so that the case no longer matches the data as stored in the database, would result in no rows being returned: 
- **Case-Sensitivity Example (2)**
``` 
select customerid, lastname 
from SalesLT.Customer
WHERE lastname = N'caprio';
```

- The `COLLATE` clause can be used to override the collation of a column and force a different collatiojn to be applied when the query is run.
```
select customerid, lastname 
from SalesLT.Customer
where LastName Collate Latin1_General_CS_AS = N'caprio'
```

### Date and Time Data Types
SQL Server doesn't offer the means to enter dates and times as literal values, so you will use character strings (often referred to as string literals) which are delimited, like all other strings in SQL Server, with single quotes. SQL Server will implicitly convert the string literals to date and time values.
    - example, a datetime could store '20140212 08:30:00' to represent February 12, 2014 at 08:30.
- SQL Server can interpret a wide variety of string literal formats as dates but, for consistency and to avoid issues with language or nationality interpretation, it is recommended that you use a neutral format, such as 'YYYYMMDD'. 
- To represent February 12, 2014, you would use the literal '20140212'.
```
SELECT orderid, custid, empid, orderdate 
FROM Sales.Orders 
WHERE orderdate = '20070825'; 
```


# Constraints
* They are a way for us to limit the data that will come into your table (hence the name "constraints")
* It will specify either one or more rules that the data you are inputting in that column must follow
## some commonly used constraints
1. Type - Restricts what datatype you can store in a column
2. Unique - Every data in a column cannot have repeating values
3. Not null - Ensures every data in a column must have a value
4. Check - Adds an extra condition on the data
    * Ex: age column must be above 18
```SQL
CREATE TABLE Person (
    Age int CHECK (Age >= 18)
)
```
5. Primary Key
    * Implicitly Unique and Not null
    * Acts as the unique identifier for the rows in a table
6. Foreign Key
    * Data in this column references the primary key of another table
    * Establishes relationships between 2 columns in the same table or different tables

# Multiplicity
* It is a way to describe the relationships between 2 tables
* We will use the primary and foreign keys to established these relationships
## Three main categories of relationships
* One to One
    * When one row in Table A is directly related to one row in Table B and vice versa
    * You must use the unique constraint in the foreign key to ensure that only one row in Table B will be related to one row in Table A
    * Ex: One person can only have one heart
* One to Many
    * When one row in Table A is related to multiple rows in Table B
    * Ex: One person has many fingers but only one finger is related to one person (you cannot share fingers!)
* Many to Many
    * Many rows in Table A is related to many rows in Table B
    * You must construct a join table to achieve many to many relationship
        * Join tables must at least consists of two columns that are both foreign keys that either points to Table A and Table B
        * Essentially, one column references Table A and one column references Table B
    * Ex: A pokemon can have many abilities and An ability can have many pokemon
        * Basically Tackle can exist to many pokemons and can share it and pokemon can have many abilities beyond just tackle


# EF Core
## What is ORM?
- **O**bject **R**elational **M**apper - It helps to map Server side language objects to relational entities of database.
- By Using ORM the developer is at ease as not much of proficiency is required to have appliaction connected with database.
- Using ORM a dev has more control over database and its entities via code.
- The dev do not need to write complex sql queries and remember the complicated syntax either.
- Eg: EntityFramework, EntityFrameworkCore, nHibernate (for java) etc...
- The ORM that we will be using is Entity Framework Core
- ORM is just a wrapper class library over the database middleware like ADO.Net

## Entity Framework Core
* One of the popular ORM for .NET core
* It allows us to work with a database by using .NET objects and almost completely removing the need for most data-access code you usually have to write (unlike our ADO.NET)

## Benefits of using EFCore:
- Compatible with .Net and its versions for Windows, macOS, Linux etc...
- Dev team do not need to be expert in complex SQL operations
- It is easy to use as every this is Object Oriented
- It also encapsulates complex ADO.Net code (as a developer you don't need to be well versed with ADO.Net)
- Since its an encapsulation to ADO.Net it helps to prevent attacks like Sql Injection. Although you can still use queries too for any complex scenario.
- Querying using EF is simply done by using Linq.

## Two approaches to EF
* Database first approach
    * This is when you created a database architecture/schema first
    * It will create the entities and DBcontext for us based on the database
* Code first approach
    * This is when you create a .NET application first
    * It will create the database for you and establish the relationships as well based on the models
    * You would need to create the DBContext

### Setup, installation and configuration (most of the steps are common for code first and Db first)
Install the listed packages in your DL project through .Net CLI or Nuget Package Manager:
- `Microsoft.EntityFrameworkCore.Design` or in VS code: ```dotnet add package Microsoft.EntityFrameworkCore.Design```
    - This should also be installed in your startup project
- `Microsoft.EntityFrameworkCore.Tools` or VSCode : ```dotnet add package Microsoft.EntityFrameworkCore.Tools```
- `Microsoft.EntityFrameworkCore.SqlServer` or in VScode:  ```dotnet add package Npgsql.EntityFrameworkCore.SQLServer```
- `Microsoft.Extensions.Configuration.Json` or in VSCode  ```dotnet add package Microsoft.Extensions.Configuration.Json```
- once you Install the packages run `dotnet ef` command in PMC to verify if Entity Framework is installed. You will see some EF picture with a unicorn as a symbol that EFCore has been installed successfully

### DB First Steps
1. Have the following:
    - Data Layer
    - The necessary packages installed in DL project
2. Run the long scaffold code in the DL project:
- `dotnet ef dbcontext scaffold "Server=DESKTOP-T5LA3TC\SQLEXPRESS;Initial Catalog=RestaurantDb;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer --output-dir Entities ` Other connection string options:
    - With Fluent API in Visual Studio PMC - `Scaffold-DbContext "Server=tcp:<server-name>.database.windows.net,1433;Initial Catalog=<Db name>; User ID=<user id>;Password=<password>;" -Provider Microsoft.EntityFrameworkCore.SqlServer -o Entities -Tables table1, table2, table3`
    - With Fluent API in VSCode terminal - `dotnet ef dbcontext scaffold "Server=tcp:<server name>.database.windows.net,1433;Initial Catalog=<db name>;User ID=<userid>;Password=<password>" Microsoft.EntityFrameworkCore.SqlServer --force -o Entities`
      or 
    - Connection String with  Data Annotaions in Visual Studio PMC - `Scaffold-DbContext "Server=tcp:<server-name>.database.windows.net,1433;Initial Catalog=<Db name>; User ID=<user id>;Password=<password>;" -Provider Microsoft.EntityFrameworkCore.SqlServer -DataAnnotations -o Entities -Tables table1, table2, table3`
    - Connection String with Data Annotations in VSCode terminal : `dotnet ef dbcontext scaffold "Server=tcp:<server name>.database.windows.net,1433;Initial Catalog=<db name>;User ID=<user id>;Password=<Password>" Microsoft.EntityFrameworkCore.SqlServer --force --data-annotations -o Entities`
3. Edit the DBContext:
    - Change the name if its weird
    - Edit the onconfiguring method to safely refer to the connection string using appsettings.json
4. Any major change to table structure:
    - If you add a new table, delete a table: go to step 2
    - If you've altered columns in an existing table: edit the necessary entity to reflect those changes

## Useful terminology/artificats to know when working with EF
* DBContext
    * Represents a session with the database
    * So any CRUD operations will start here
    * Also used to configure how EF will construct your database architecture using **Fluent API** in OnModelCreating() method
* Migration - for code - first approach only
    * They are a snapshot of the database architecture given the current state of your models
    * So if you change your models/db architecture, you would need to create another migration and update the database
* Entities
    * It is the model version of the tables of your database
    * So a Student table in Database will have a student entity in EF core
* Relationships
    * Same thing as multiplicity in SQL
    * They way you signify the relationships will be use of data annotations/Fluent API/Model structure
* [Data Annotations](https://www.entityframeworktutorial.net/code-first/dataannotation-in-code-first.aspx)
    * When you use Scaffolding there is an option to add flag `-DataAnnotations` which means you will see entity classes with some attributes/annotations on the top like `[Key]`, `[StringLength]` etc
    * Data Annotations attributes are .NET attributes which can be applied on an entity class or properties to override default conventions in EF.
    * Data annotation attributes are included in the `System.ComponentModel.DataAnnotations` and `System.ComponentModel.DataAnnotations.Schema` 
* **Note**: Data annotations only give you a subset of configuration options. Fluent API provides a full set of configuration options available in Code-First. This is why Microsoft suggests to use **[Fluent API](https://www.entityframeworktutorial.net/code-first/fluent-api-in-code-first.aspx)** instead of Data Annotations.

Other things you'll need with DBFirst:
- A Mapper to map your DB entities to BL entities
- [Tutorial guide](https://www.entityframeworktutorial.net/what-is-entityframework.aspx)
- [Exercises](https://learn.microsoft.com/en-us/training/modules/persist-data-ef-core/)

## EF Core - Code First
- Most conventions and steps for EFCore Code first and EF6 are same
### Packages
- Install the listed packages in your DL project:
- `dotnet add package Microsoft.EntityFrameworkCore.Tools or Install-Package Microsoft.EntityFrameworkCore.Tools`
- `dotnet add package Microsoft.EntityFrameworkCore.SQLServer or Install-Package Microsoft.EntityFrameworkCore.SQLServer`
## Code First Steps
1. Have the following:
   - Data Layer
   - The necessary packages installed in DL project
   - Configure connection string. For our project with many layers, it is recommended to keep connection string in the User Secrets of Asp.Net core web API project.
2. Implement a DbContext
   - Override the OnConfiguring method to point to the connection string stored in your appsettings.json. Not required if you are configuring the Connection String in API project. 
   - Override the OnModelCreating method to manually map some relationships EF Core complains about
3. Run the migration code in the DL project
    - `dotnet ef migrations add NameOfMigration -c DbContext --startup-project <relative path to project file>. Ex dotnet ef migrations add InitialCreate -c PokeDbContext --startup-project ../PokemonApi/PokemonApi.csproj`
                       or
    - `Add-Migration "Name of the Migration" (In PMC point it to Data project)`
4. Update your DB in the DL project
    - `dotnet ef database update --startup-project <relative path to project file>` or
    - `Update-Database (In PMC point it to Data project)`
5. Any changes to your models/entities go to step 3

# [Stored Procedures](https://learn.microsoft.com/en-us/sql/relational-databases/stored-procedures/stored-procedures-database-engine?view=sql-server-ver16)
A Stored procedure are named collections of T-SQL statements created with `CREATE PROCEDURE` command. They encapsulate many server and database commands and can provide a consistent API to client applications using input parameters, output parameters and return values.
- Procedures can return results, manipulate data and perfrom administrative actions on the server.
- Using Stored procedures also ensure a layer is creates that developers and admins can ensure that all activity is performed by trusted code modules that validate input and also handle the errors.
- Execute Store procedure using `EXECUTE <name of of the proc>` or `EXEC <name of the proc>` command 
## Benefits of a stored procedure
- Reduced server/client network traffic
- Stronger security
- Code reusability
- Easier maintainence
- Improved performance

## Dynamic SQL Queries
Dynamic SQL queries provides a mechanism for constructing a character string that is passed to SQL Server, interpreted as a command and executed.
- Why? You might not know all the values necessaru for your query unitl execution time. Such as taking the results of one query (ex pivot query) or an administrative maintainence routine that accepts objects names at runtime. 
- TSQL supports 2 methods to build dynamic SQL expressions:
1. Using `EXECUTE` or `EXEC` Command : It does not support any parameters and supports use of a string as an input
```
DECLARE @sqlstring as Varchar(1000)
SET @sqlstring = 'SELECT empid,' +' lastname '+' FROM HR.Employees;'
EXEC (@sqlstring);
Go
```
2. Using System stored procedure `sp_executesql`: supports string input for the query as well as allow additional input parameters.
```
DELCARE @sqlstring as nvarchar(256) = N'SELECT GETDATE() as date';
EXEC sp_executesql @statement = @sqlcode;
go
```
- [Activity on Stored procedure, dynamic sql and functions](https://learn.microsoft.com/en-us/training/modules/create-stored-procedures-table-valued-functions/)

## Union, Union All
UNION and UNION ALL provide a mechanism to add one set to another; you can then stack result sets from two or more queries into a single output result set. 
- UNION stacks rows, compared to JOIN, which combines columns from different sources. 
- It is a form of SET operator and as per set theory, a set does not provide a sort order and includes only distinct rows. If you need the results sorted, you should add an ORDER BY to the final results, as you may not use it inside the input queries. 

- UNION combines all rows from each input set, and then filters out duplicates. By using the UNION operator, you can combine rows from one input set with rows from another into a resulting set. If a row appears in either of the input sets, it will be returned in the output. Duplicate rows are eliminated by the UNION operator. 
- In UNION operator, you can combine rows from one input set with rows from another into a resulting set. If a row appears in either of the input sets, it will be returned in the output. Duplicate rows are eliminated by the UNION operator. 
- From a performance standpoint, the use of UNION will include a filter operation, whether or not there are duplicate rows. If you need to combine setsand know that there are no duplicates, consider using UNION ALL to save the overhead of the distinct filter. 

## EXCEPT and INTERSECT
While UNION and UNION ALL combine all rows from input sets, you might need to return either only those rows in one set but not in the other—or only rows that are present in both sets. For these purposes, the EXCEPT and INTERSECT operators might be useful to your queries.
- The T-SQL INTERSECT operator, added in SQL Server 2005, returns only distinct rows that appear in both input sets.  No duplicate rows will be returned by the operation. No duplicate rows will be returned by the operation. 
- The T-SQL EXCEPT operate, added in SQL Server 2005, returns only distinct rows that appear in one set and not in the other. Specifically, EXECPT returns rows from the input set listed first in the query.

## Derived Tables
- Previously you learned about subqueries, which are queries nested within other SELECT statements. 
- Like subqueries, you create derived tables in the FROM clause of an outer SELECT statement.
- Unlike subqueries, you write derived tables using a named expression that is logically equivalent to a table and may be referenced as a table elsewhere in the outer query.
- Derived tables allow you to write T-SQL statements that are more modular, helping you break down complex queries into more manageable parts. 
- Using derived tables in your queries can also provide workarounds for some of the restrictions imposed by the logical order of query processing, such as the use of column aliases. 
- When writing queries that use derived tables, consider the following: 
    - Derived tables are not stored in the database. Therefore, no special security privileges are required to write queries using derived tables, other than the rights to select from the source objects. 
    - A derived table is created at the time of execution of the outer query and goes out of scope when the outer query ends. 
    -  Derived tables do not necessarily have an impact on performance, compared to the same query expressed differently. When the query is processed, the statement is unpacked and evaluated against the underlying database objects.
- When writing queries that use derived tables, keep the following guidelines in mind: 
    - The nested SELECT statement that defines the derived table must have an alias assigned to it. The outer query will use the alias in its SELECT statement in much the same way you refer to aliased tables joined in a FROM clause.
    - All columns referenced in the derived table's SELECT clause should be assigned aliases, a best practice that is not always required in T-SQL. Each alias must be unique within the expression. The column aliases may be declared inline with the columns or externally to the clause.
        - When using external aliases, if the inner query is executed separately, the aliases will not be returned to the outer query. For ease of testing and readability, it is recommended that you use inline rather than external aliases. 
    - The SELECT statement that defines the derived table expression may not use an ORDER BY clause, unless it also includes a TOP operator, an OFFSET/FETCH clause. As a result, there is no sort order provided by the derived table. You sort the results in the outer query.
    -  The SELECT statement that defines the derived table may be written to accept arguments in the form of local variables. If the SELECT statement is embedded in a stored procedure, the arguments may be written as parameters for the procedure.
    - Derived table expressions that are nested within an outer query can contain other derived table expressions. Nesting is permitted, but it is not recommended due to increased complexity and reduced readability.

## Common Table Expressions
Another form of table expression provided by SQL Server is the CTE. Similar in some ways to derived tables, CTEs provide a mechanism for defining a subquery that may then be used elsewhere in a query. Unlike a derived table, a CTE is defined at the beginning of a query and may be referenced multiple times in the outer query.
- CTEs are named expressions defined in a query. Like subqueries and derived tables, CTEs provide a means to break down query problems into smaller, more modular units. 
- When writing queries with CTEs, consider the following guidelines: 
    - Like derived tables, CTEs are limited in scope to the execution of the outer query. When the outer query ends, so does the CTE's lifetime. 
    - CTEs require a name for the table expression, in addition to unique names for each of the columns referenced in the CTE's SELECT clause.
    - CTEs may use inline or external aliases for columns. 
    -  Unlike a derived table, a CTE may be referenced multiple times in the same query with one definition. Multiple CTEs may also be defined in the same WITH clause. 
    - CTEs support recursion, in which the expression is defined with a reference to itself. 
        - [Recursive CTE](https://docs.snowflake.com/en/user-guide/queries-cte) is a CTE that references to itself . A recursive CTE can join a table to itself as amny times as necessary to process hierarchiical data in the table.
        ```
        WITH [ RECURSIVE ] <cte_name> AS
        (
        <anchor_clause> UNION ALL <recursive_clause>
        )
        SELECT ... FROM ...;
        ```
## APPLY Operator
As an alternative to combining or comparing rows from two sets, SQL Server provides a mechanism to apply a table expression from one set on each row in the other set.
- SQL Server provides the APPLY operator to enable queries that evaluate rows in one input set against the expression that defines the second input set. 
- APPLY is a table operator, not a set operator. You will use APPLY in a FROM clause, like a JOIN, rather than as a set operator that operates on two compatible result sets of queries. 
- Conceptually, the APPLY operator is similar to a correlated subquery in that it applies a correlated table expression to each row from a table. However, APPLY differs from correlated subqueries by returning a table-valued result rather than a scalar or multi-valued result.
- When describing input tables used with APPLY, the terms “left” and “right” are used in the same way as they are with the JOIN operator, based on the order in which they appear, relative to one another in the FROM clause.
- Syntax - Each result from the left table source will be passed as an input to the right table source:
```
SELECT <column_list> 
FROM <left_table_source> AS <alias> 
[CROSS]|[OUTER] APPLY 
 <right_table_source> AS <alias>;
```
- APPLY supports two different forms: CROSS APPLY and OUTER APPLY
    - **CROSS APPLY** - The CROSS APPLY form of the operator will include in the output result set only those values from the left table source where a value is found in the right table source. 
        -  Note that the term CROSS, when used in CROSS APPLY, does not have the same meaning as CROSS when used in CROSS JOIN. Whereas a CROSS JOIN returns all the possible combinations of the left and right table sources, CROSS APPLY returns only the values from the left table source where a value is found in the right table source.
        - This makes a CROSS APPLY statement very similar to an INNER JOIN—this similarity is such that almost all T-SQL statements that include an INNER JOIN between two tables can be rewritten as a statement using CROSS APPLY.
    - **OUTER APPLY** - As you learned in an earlier topic, APPLY executes the right table source for each of the rows in the left table source, and returns the results as a single result set. 
        - The OUTER APPLY form of the operator will include all the values from the left table source in the output result set and values from the right table source where they exist. Where the right table source does not contain a value for a left table source value, columns derived from the right table source will have a NULL value. 
        -  This makes an OUTER APPLY statement very similar to a LEFT OUTER JOIN—this similarity is such that almost all T-SQL statements that include a LEFT OUTER JOIN between two tables can be rewritten as a statement using OUTER APPLY.
        - As with LEFT OUTER JOIN, the order in which the table sources appear might influence the result. 
        - The following SELECT statement uses a LEFT OUTER JOIN between the suppliers table and the customers table to show all countries where suppliers are located—and which of those countries also contain customers:
        ```
        SELECT DISTINCT s.country AS supplier_country, c.country as customer_country 
        FROM Production.Suppliers AS s 
        LEFT OUTER JOIN Sales.Customers AS c 
        ON c.country = s.country 
        ORDER BY supplier_country; 
        ```
        -  Notice that the JOIN predicate Sales.Customers.Country = Production.Suppliers.Country moves from the LEFT OUTER JOIN clause to the WHERE clause of the right table source when the query is rewritten to use OUTER APPLY.
        ```
        SELECT DISTINCT s.country AS supplier_country, c.country as customer_country 
        FROM Production.Suppliers AS s 
        OUTER APPLY ( SELECT country 
        FROM Sales.Customers AS cu 
        WHERE cu.country = s.country 
        ) AS c 
        ORDER BY supplier_country;
        ```
### CROSS APPLY and OUTER APPLY FEATURE
As you learned in the previous topics, there are many similarities between CROSS APPLY and INNER JOIN, and OUTER APPLY and LEFT OUTER JOIN. 
- However, the APPLY operators enable some types of query to be executed which could not be written using JOINs. These queries rely on the left table source being processed before being applied to the right table source. Two examples shown in this topic are using a query returning top results for each input value and a TVF as the right table source. 
- A sales manager has requested a report showing the three most recent orders for each customer, including customers with no orders. The following query is one way to meet this requirement: OUTER APPLY: Three Most Recent Orders Per Customer Example
```
SELECT C.custid, TopOrders.orderid, TopOrders.orderdate 
FROM Sales.Customers AS C 
OUTER APPLY 
 (SELECT TOP (3) orderid, CAST(orderdate AS date) AS orderdate 
 FROM Sales.Orders AS O 
 WHERE O.custid = C.custid 
 ORDER BY orderdate DESC, orderid DESC) AS TopOrders;
```
- Note that because OUTER APPLY is used here, customers with no orders are included in the result (with NULL in the orderid and orderdate columns). If CROSS APPLY were used instead of OUTER APPLY, customers with no orders would not appear in the results. Partial results, including rows with NULLs, appears.
- A TVF might be used as the right table source for an instance of the APPLY operator. 
- The following example uses the supplierid column from the left input table as an input parameter to a TVF named dbo.fn_TopProductsByShipper. If there are rows in the Suppliers table with no corresponding products, the rows will not be displayed.
```
SELECT S.supplierid, s.companyname, P.productid, P.productname, P.unitprice 
FROM Production.Suppliers AS S 
CROSS APPLY dbo.fn_TopProductsByShipper(S.supplierid) AS P;
```
- Note that because CROSS APPLY is used here, suppliers with no products are 
excluded from the result. 

## [CURSORS](https://www.youtube.com/watch?v=INw_KGjyfDw)
Relational Database Management Systems, including sql server are very good at handling data in SETS. For example, the following "UPDATE" query, updates a set of rows that matches the condition in the "WHERE" clause at the same time. 
- `Update tblProductSales Set UnitPrice = 50 where ProductId = 101`

- However, if there is ever a need to process the rows, on a row-by-row basis, then cursors are your choice. Cursors are very bad for performance, and should be avoided always. Most of the time, cursors can be very easily replaced using joins.

-  A cursor is a database object that allows you to retrieve and manipulate rows from a result set one at a time. Cursors are useful when you need to perform operations on each row of a result set rather than on the set as a whole.
