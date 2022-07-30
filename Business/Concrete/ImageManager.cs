using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ImageManager : IImageService
    {
        IImageDal _imageDal;
        IFileHelper _fileHelper;

        public ImageManager(IImageDal imageDal, IFileHelper fileHelper)
        {
            _imageDal = imageDal;
           _fileHelper = fileHelper;
        }
          
            public IResult Add(IFormFile file, Image image)
            {
                IResult result = BusinessRules.Run(CheckIfCarImageLimit(image.Id));
                if (result != null)
                {
                    return result;
                }
                image.ImagePath = _fileHelper.Upload(file, PathConstants.ImagesPath);
                image.Date = DateTime.Now;
                _imageDal.Add(image);
                return new SuccessResult("Resim başarıyla yüklendi");
            }

            public IResult Delete(Image image)
            {
                _fileHelper.Delete(PathConstants.ImagesPath + image.ImagePath);
                _imageDal.Delete(image);
                return new SuccessResult();
            }

            public IResult Update(IFormFile file, Image image)
            {
                image.ImagePath = _fileHelper.Update(file, PathConstants.ImagesPath + image.ImagePath, PathConstants.ImagesPath);
                _imageDal.Update(image);
                return new SuccessResult();
            }

            public IDataResult<List<Image>> GetByPersonId(int Id)
            {
                var result = BusinessRules.Run(CheckPersonImage(Id));
                if (result != null)
                {
                    return new ErrorDataResult<List<Image>>(GetDefaultImage(Id).Data);
                }
                return new SuccessDataResult<List<Image>>(_imageDal.GetList(p => p.PersonId == Id));
            }

            public IDataResult<Image> GetByImageId(int imageId)
            {
                return new SuccessDataResult<Image>(_imageDal.Get(p => p.PersonId == imageId));
            }

            public IDataResult<List<Image>> GetAll()
            {
                return new SuccessDataResult<List<Image>>(_imageDal.GetList());
            }
            private IResult CheckIfCarImageLimit(int Id)
            {
                var result = _imageDal.GetList(p => p.PersonId == Id).Count;
                if (result >= 5)
                {
                    return new ErrorResult();
                }
                return new SuccessResult();
            }
            private IDataResult<List<Image>> GetDefaultImage(int Id)
            {

                List<Image> PersonImage = new List<Image>();
              PersonImage.Add(new Image { PersonId = Id, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
                return new SuccessDataResult<List<Image>>(PersonImage);
            }
            private IResult CheckPersonImage(int Id)
            {
                var result = _imageDal.GetList(p => p.PersonId == Id).Count;
                if (result > 0)
                {
                    return new SuccessResult();
                }
                return new ErrorResult();
            }
        }
    }
