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
    public class ModelController
    {
        private ModelRepository _modelRepository;

        public ModelController()
        {
            _modelRepository = new ModelRepository();
        }

        public bool Add(ModelInfo modelInfo)
        {
            bool isValid = ValidationHelper.IsModelNameValid(modelInfo);

            if (isValid)
            {
                _modelRepository.Export(modelInfo);
            }

            return isValid;
        }

        public List<ModelInfo> Get()
        {
            return _modelRepository.Import();
        }
    }
}
