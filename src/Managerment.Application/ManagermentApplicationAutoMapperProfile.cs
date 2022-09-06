using AutoMapper;
using Managerment.Categories;
using Managerment.Customers;
using Managerment.DetailProductRepairs;
using Managerment.Manufacturers;
using Managerment.OrderRepairs;
using Managerment.PaymentHistories;
using Managerment.PaymentMethods;
using Managerment.ProcessRepairs;
using Managerment.ProductConditions;
using Managerment.ProductRepairs;
using Managerment.Products;
using Managerment.ProductUnits;
using Managerment.Roles;
using Managerment.Stores;
using Managerment.Suppliers;
using Managerment.Users;

namespace Managerment;

public class ManagermentApplicationAutoMapperProfile : Profile
{
    public ManagermentApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
        CreateMap<Category, CategoryDto>();
        CreateMap<Manufacturer, ManufacturerDto>();
        CreateMap<Supplier, SupplierDto>();
        CreateMap<ProductCondition , ProductConditionDto>();
        CreateMap<ProductUnit, ProductUnitDto>();
        CreateMap<Product, ListProductDto>();
        CreateMap<Customer, CustomerDto>();
        CreateMap<Customer, CustomerListDto>();
        CreateMap<PaymentHistory, PaymentHistoryDto>();
        CreateMap<PaymentMethod, PaymentMethodDto>();
        CreateMap<Category, ListCategoryDto>();
        CreateMap<User, UserDto>();
        CreateMap<Role, RoleDto>();
        CreateMap<Store, StoreDto>();
        CreateMap<DetailProductRepair, DetailProductRepairDto>();
        CreateMap<ProductRepair, ProductRepairDto>();
        CreateMap<DetailProductRepairDto, CreateDetailProductRepairDto>();
        CreateMap<ProductRepair , DetailListProductRepairDto >().ForMember(x=>x.PR_repair_type , y=>y.MapFrom(z=>z.Product_repair_type));
        CreateMap<DetailProductRepairCreateOrderDetailDto, CreateDetailProductRepairDto>();
        CreateMap<OrderRepair, OrderRepairDto>();
        CreateMap<DetailProductRepairCreateOrderDetailDto, DetailProductRepair>();
        CreateMap<ProcessRepair, ProcessRepairDto>();
    }
}
