# OnlineBookStore (Bulky)
 
An ASP.NET Core e-commerce application for an online bookstore, built on **.NET 8**. The solution is organized as a set of class libraries following a repository / unit-of-work pattern, with a Razor Pages web front end.
 
> Internally the project is named **Bulky** (namespaces `Bulky.*`, database `BulkyRazorBookDB`) — a bulk/wholesale-style bookstore where products can have tiered pricing.
 
## Project Structure
 
| Project | Description |
|---|---|
| `Bulky.Models` | Domain entities (`Product`, `Category`, `Company`, `ShoppingCart`, `OrderHeader`, `OrderDetail`, `ApplicationUser`, `ProductImage`) and view models (`ProductVM`, `OrderVM`, `ShoppingCartVM`, `RoleManagementVM`) |
| `Bulky.DataAccess` | EF Core `ApplicationDbContext`, database migrations, and the Repository / Unit-of-Work data access layer (`IRepository`, `UnitOfWork`, per-entity repositories, `DbInitializer` for seeding) |
| `Bulky.Utility` | Cross-cutting helpers: role/status constants (`SD`), `EmailSender`, and `StripeSettings` |
| `BulkyRazorBook` | The runnable ASP.NET Core **Razor Pages** web application (entry point, `Program.cs`, `appsettings.json`, `wwwroot`) |
| `BulkyBook` | Placeholder project (currently empty) |
 
## Tech Stack
 
- **.NET 8** / ASP.NET Core
- **Razor Pages** for the web UI
- **Entity Framework Core 8** (`Microsoft.EntityFrameworkCore.SqlServer`) with SQL Server / LocalDB
- **ASP.NET Core Identity** (`ApplicationUser : IdentityUser`, role management) for authentication/authorization
- **Stripe** for payment processing (`StripeSettings`, `PaymentIntentId`/`SessionId` on orders)
- Repository + Unit of Work pattern for data access
## Domain Overview
 
- **Products** — books with a title, description, ISBN, author, category, product images, and **tiered pricing** (`Price` for 1–50 units, `Price50` for 50+, `Price100` for 100+), intended for bulk/wholesale ordering.
- **Categories** — used to group and order products (`DisplayOrder`).
- **Companies** — B2B customers can be associated with a `Company` for delayed/invoiced payment.
- **Shopping Cart** — per-user cart items tied to `ApplicationUser` and `Product`.
- **Orders** — `OrderHeader` (shipping info, totals, payment/order status, Stripe session & payment intent) and `OrderDetail` (line items).
- **Roles** — defined in `SD.cs`: `Admin`, `Employee`, `Company`, `Customer`.
- **Order/Payment statuses** — Pending, Approved, Processing, Shipped, Cancelled, Refunded (order); Pending, Approved, ApprovedForDelayedPayment, Rejected (payment).
## Current Implementation Status
 
The `BulkyRazorBook` web app currently implements full CRUD Razor Pages for **Categories** (`Pages/Categories/Index|Create|Edit|Delete`), along with the default Index, Privacy, and Error pages. The richer domain model in `Bulky.Models`/`Bulky.DataAccess` (products, shopping cart, orders, Stripe payments, Identity roles) is scaffolded and ready to be wired up to additional pages/controllers as the app grows.
 
## Getting Started
 
### Prerequisites
 
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- SQL Server or SQL Server LocalDB
### Setup
 
1. Clone the repository:
```bash
   git clone https://github.com/Kobbykk/OnlineBookStore.git
   cd OnlineBookStore
```
2. Update the connection string in `BulkyRazorBook/appsettings.json` if needed (defaults to LocalDB):
```json
   "ConnectionStrings": {
     "BulkyRazorBookConnection": "Server=(localdb)\\mssqllocaldb;Database=BulkyRazorBookDB;Trusted_Connection=True;MultipleActiveResultSets=true"
   }
```
3. Apply database migrations:
```bash
   cd BulkyRazorBook
   dotnet ef database update
```
4. Run the application:
```bash
   dotnet run
```
5. Open the app in your browser at the URL shown in the console (e.g. `https://localhost:5001`).
## License
 
No license file is currently included in this repository.
