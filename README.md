# Inventory Management System (DevExpress WinForms)

This project is a Windows Forms application designed to manage inventory data. It leverages **DevExpress** controls for a modern and professional user interface.

---

## Features

### Core Features
- **Product Management**
   - Display products in a grid with sorting, filtering, and grouping capabilities.
   - CRUD operations for products using an intuitive UI.     
- **Supplier Integration**
   - Display supplier information.
- **Stock Tracking**
  - Visualize stock levels and suggestions for reorders.

### Analytics Dashboard
- **Stock Levels Analysis**: 
  - Visualize stock levels by category using a bar chart.
- **Reorder Alerts**: 
  - Display products below reorder levels as customizable tiles, with a critical stock indicator.
- **Supplier Contribution**:
  - A pie chart showing the percentage of stock provided by each supplier, with small contributors grouped into "Others".
- **Top Products**:
  - Bar chart highlighting the top 10 revenue-generating products.
- **Sales Trends**:
  - Line chart displaying monthly sales trends.

### Reporting
- Generate reports for stock levels, reorder points, and product details.
- Export data to PDF, Excel, or CSV formats.

---

## Screenshots
![Database management](https://raw.githubusercontent.com/Smileybob72801/InventoryControl/refs/heads/master/Docs/Screenshots/DeleteProducts.png)


## Technologies Used

1. **Frontend**
   - **DevExpress WinForms**: Ribbon, Data Grids, Chart Controls, Tile Controls, and more for a professional UI.

2. **Backend**
   - **Entity Framework Core**: ORM for seamless database integration with the Northwind database.
   - **MVVM Framework**: Implements MVVM for a clean separation of concerns.

3. **Database**
   - **Northwind**: Sample database with `Products`, `Categories`, `Suppliers`, `Orders`, and related tables.

---

## Build the Project

Clone the repository:
```bash
git clone https://github.com/Smileybob72801/InventoryControl.git
```

You will need to edit the DB connection string to match your server.

```bash
cd InventoryControl/InventoryControl
```

```bash
dotnet build
```

```bash
dotnet run
```

---

## Roadmap
- Inline validation
- Advanced Search
- Drilldown function for insights
- Move the DBContext to a DI container
- Undo Functionality
- Accessibility Enchancements
- Localization Support
