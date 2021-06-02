# HW_Week06_Day05_Many-To-Many

# Class B

قم بإنشاء علاقة many-to-many باستخدام جدول Customers و Products

## Create new table in model 
```
    public class Customer_ProductModel
    {
        public int id { get; set; }

        public int customerId { get; set; }
        public CustomerModel CustomerModel { get; set; }

        
        public int productId { get; set; }
        public ProductModel ProductModel { get; set; }
    }
```
# Add list in both table of Customer and Product

```   

        public List<Customer_ProductModel> Customer_ProductModel { get; set; }

 ```

 ## Add table Customer_ProductModel in AppDbContext 
 
 ```
    public DbSet<Customer_ProductModel> Customer_Product { get; set; }

```  

## Add migrations and update database

```
dotnet ef migtation add addTableCustomer_ProductModel

```

```

dotnet ef database update 

```

