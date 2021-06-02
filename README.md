
### Many-To-Many

- In this relation a new table need to be created to represent the relationship
- Let's create a new table first to have a m-to-m relation first name it *CouponModel.cs*

```csharp
 public class CouponModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
```

```csharp
public DbSet<CouponModel> Coupons { get; set; }
```

```vbnet
dotnet ef migrations add CreateCouponTable
```

```vbnet
dotnet ef database update
```

- Join the two table and name it after the join entity *CouponCustomer.cs*

```csharp
public class CouponCustomer
    {
        public int CouponId { get; set; }
        public CouponModel Coupon { get; set; }
        public int CustomerId { get; set; }
        public CustomerModel Customer { get; set; }
    }
```

```csharp
public DbSet<CouponCustomer> CouponCustomer { get; set; }
```

- add these to both entity *CouponModel.cs* and *CustomerModel.cs*

```csharp
public List<CouponCustomer> CouponCustomer { get; set; }
```

- The relationship also needs to be configured via the Fluent API in *AppDbContext.cs* file inside *OnModelCreating* method

```csharp
modelBuilder.Entity<CouponCustomer>()
                .HasKey(cc => new { cc.CouponId, cc.CustomerId });
            modelBuilder.Entity<CouponCustomer>()
                .HasOne(cc => cc.Coupon)
                .WithMany(b => b.CouponCustomer)
                .HasForeignKey(cc => cc.CouponId);
            modelBuilder.Entity<CouponCustomer>()
                .HasOne(cc => cc.Customer)
                .WithMany(c => c.CouponCustomer)
                .HasForeignKey(cc => cc.CustomerId);
```

```vbnet
dotnet ef migrations add JoinCouponCustomer
```

```vbnet
dotnet ef database update
```

# HW_Week06_Day05_Many-To-Many

# Class A
قم بإنشاء علاقة many-to-many باستخدام جدول Teachers و Students 


![Table](https://uc1974686d6dae5dfe28dd83b23a.previews.dropboxusercontent.com/p/thumb/ABKQyUn-CNNRpArO9VuKgTufsFPYXF_v9C55QC8JXrefOtos6O4CEgO-SQ7Pno6KNhydNBxO-upPNLOrYl2XGv38Uzl3VzUW3XFZxcd4NmeB6icX_BhpReobNQaB0islfQf5OONKBMGISR60N9XYyHr_KSMSwBw8740_NWLFHbxy0zydDT4J03XN6Eb-fDp416Fv2dH-Tpi02PbGjo6OylLvVmSA35i7pgLn3qE3XPkBjSOCa6OL7MikjQS8vOFjkJTt1L1HAS25DqgSTViHt0vZw4e6B_rcdA4WcFG7IVDI6_Ug04Lh107p5lw5VmaHPxC-vBkAbGlW86-0kN0mPNvebBxano6ystBAzvDm-M7BfkFSVp3G4K_555wBk5C4L1edrO9DkIG2nrOc9YhIAoUafrv9ofRGR8ifqAozzD3s_A/p.png)

# Class B

قم بإنشاء علاقة many-to-many باستخدام جدول Customers و Products

![Table](https://uc86a7d58364ec1589a96e0f5c1d.previews.dropboxusercontent.com/p/thumb/ABKLh1_yF_ab35risW4KhJNuZxQrWJk63x0kazBqHAFRdVNj_KP2udnwkMNTiDnvYnew2U3UjLWJhOJyu-1sggf-369HdK8vAvOU9nMk1EME4rRKIn7zRGySNL1nlzWMjR_iW8JRP7cgCJuUKC6aTm6X1dchUH0WA2LxFg3S2FPwZ8ROXwLWgae2O1wMXkcGeKUEmug9d65omGd-k_mtjSx-Ssx3rc28avlRApos5HC6YZcAMVaymUrP8jdpKDShr1PWXROvTLGHnxAl1dIdPetxOhVwt2Lur6S3Gv7kLxXo0P8qsR0eqbCpUGNAipS1PPR-5AW1VjKnTGLr9xSKa0y1D74ViJeK-XDZBpweTbOARZnPqm-z1yHcGlAbGtJ82-9yBeUnHEEi43o9M0uUjV4H/p.png)
