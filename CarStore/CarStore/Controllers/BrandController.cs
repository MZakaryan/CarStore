using CarStore.Helpers;
using CarStoreInfo;
using CarStoreRepository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    public class BrandController
    {
        BrandRepository _brandRepository;

        public BrandController()
        {
            _brandRepository = new BrandRepository();
        }

        public bool Add(BrandInfo brandInfo)
        {
            bool isValid = ValidationHelper.IsBrandNameValid(brandInfo);
            if (isValid)
            {
                if (!_brandRepository.Export(brandInfo))
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public List<BrandInfo> Get()
        {
            return _brandRepository.Import();
        }
    }
}