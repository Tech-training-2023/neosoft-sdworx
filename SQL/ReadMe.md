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