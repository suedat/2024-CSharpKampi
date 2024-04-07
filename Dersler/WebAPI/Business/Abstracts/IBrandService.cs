using System;
using Entities.Concretes;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
namespace Business.Abstracts
{
	public interface IBrandService
	{
		CreatedBrandResponse Add(CreateBrandRequest createBrandRequest);
		//veri tabanı nesnelerimizi API veya son kullanıcıya taşımıyoruz. ne isteyeceğiz ne göstereceğiz

		List<GetAllBrandResponse> GetAll();

	}
	//responses and requests
}

