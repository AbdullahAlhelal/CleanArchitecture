using Microsoft.AspNetCore.Builder;
namespace clean_architecture.Contract
{
    //Response
    public class CarsContract
        {
        public string CarName { get; set; }
    }
    //request   
    public class CarsContractOpertions
    {
        public string CarName { get; set; }
    }
}
