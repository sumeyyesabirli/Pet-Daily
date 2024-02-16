namespace CatDaily.Business.Models.ResponseModel
{
	public class GetAnimalTypeListResponseModel
	{
        public int Id { get; set; }
        public string Code { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
	}
}
