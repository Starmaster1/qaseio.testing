namespace BussinesObjects.API.RestEntities
{
    public class CommonResultResponse<T>
    {
        public bool Status { get; set; }
        public T Result { get; set; }
    }
}
