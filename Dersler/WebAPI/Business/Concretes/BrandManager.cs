using System;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
	public class BrandManager : IBrandService
	{
        private readonly IBrandDal _brandDal;

        //dependency injection
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
        {
            //business rules

            //mapping  --> automapper
            //gelen requesti veri tabanı nesnemize çeviriyoruz
            Brand brand = new();
            brand.Name = createBrandRequest.Name;
            brand.CreatedDate = DateTime.Now;

            _brandDal.Add(brand);

            //veri tabanından geleni responsa çevirip döndürüyoruz
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Name = brand.Name;
            createdBrandResponse.Id = 4;
            createdBrandResponse.CreatedDate = brand.CreatedDate;

            return createdBrandResponse;
            
        }

        public List<GetAllBrandResponse> GetAll()
        {
            List<Brand> brands = _brandDal.GetAll();

            List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();

            foreach (var brand in brands)
            {
                GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
                getAllBrandResponse.Name = brand.Name;
                getAllBrandResponse.Id = brand.Id;
                getAllBrandResponse.CreatedDate = brand.CreatedDate;

                getAllBrandResponse.Add(getAllBrandResponse);
            }
            return getAllBrandResponses;
        }
    }
}

