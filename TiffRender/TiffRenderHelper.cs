/***********************************************************************************************
 * Copyright(c) 2018-2024 YaMo Studio All rights reserved.
 * 
 * File Infomation:
 *      Class Name : TiffRenderHelper
 *      Description : class description
 *      Author : YaMo Studio
 *      Create Date : 2024/10/9 20:49:20
 * 
 * Revision Record:
 *      1.Create this file at 2024/10/9 20:49:20 by YaMo Studio.
 ***********************************************************************************************/
using ImageMagick;
using ImageMagick.Formats;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TiffRender
{
    /// <summary>
    /// class description
    /// </summary>
    public static class TiffRenderHelper
    {
        private static readonly string[] Defines =
        {
                "34022", // ColorTable
                "34025", // ImageColorValue
                "34026", // BackgroundColorValue
                "32928"
        };

        public static async Task<BitmapSource> Tiff2BitmapSource(FileInfo fileInfo)
        {
            var magickImage = new MagickImage();
            MagickFormat format;
            magickImage.Quality = 100;

            var extension = fileInfo.Extension.ToLowerInvariant();

            switch (extension)
            {
                case ".tif":
                case ".tiff":
                    magickImage.Settings.SetDefines(new TiffReadDefines
                    {
                        IgnoreTags = Defines,
                    });
                    format = MagickFormat.Tif;
                    break;
                default:
                    format = MagickFormat.Unknown;
                    break;
            }


            if (fileInfo.Length >= 2147483648)
            {
                await Task.Run(() =>
                {
                    // Fixes "The file is too long. This operation is currently limited to supporting files less than 2 gigabytes in size."
                    // ReSharper disable once MethodHasAsyncOverload
                    magickImage.Read(fileInfo);
                });
            }
            else
            {
                await magickImage.ReadAsync(fileInfo, format).ConfigureAwait(false);
            }

            magickImage?.AutoOrient();
            if (magickImage is null)
            {
                return null;
            }

            var bitmap = magickImage.ToBitmapSource();
            bitmap.Freeze();
            return bitmap;
        }
    }
}
