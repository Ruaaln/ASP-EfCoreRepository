![ASP-EfCoreRepository Banner](banera-img.png)

# ASP-EfCoreRepository

ASP.NET Core MVC layihəsi.  
EF Core **Code First** və **Repository Pattern** istifadə olunub.  
Məqsəd: DbContext-i birbaşa Controller-də istifadə etmədən, səliqəli və genişlənə bilən CRUD arxitekturası qurmaq.

## Features
- EF Core Code First + Migrations
- Repository Pattern (User, Product, Category, Order, Favorite)
- Admin Panel (Bootstrap 5)
- Product & Category CRUD
- Custom Error Pages (404 / 500)

## Admin Routes
- Dashboard: `/Admin/Index`
- Products: `/Admin/ProductList`
- Categories: `/Admin/CategoryList`
- Add Product: `/Admin/AddProduct`
- Add Category: `/Admin/AddCategory`

## Setup

### Connection String
`appsettings.json` faylında connection string-i öz mühitinizə uyğun dəyişin.

```json
"ConnectionStrings": {
  "SqlServer": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EfCoreStoreDB;Integrated Security=True;TrustServerCertificate=True;"
}

```
<h3><b>Daha sonra database-i update edin<b/><h3/>

```Terminal
Update-database

```
