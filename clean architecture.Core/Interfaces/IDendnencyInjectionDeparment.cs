namespace clean_architecture.Core.Interfaces
{
    public interface IDendnencyInjectionDeparment
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userid"></param>
        /// <returns>  Return Salay Employee By Name </returns>
        string GetUserDeparmentByUserID(Guid userid);
        string GetUserNameAndJobByUserID(Guid userid);
    }
}
