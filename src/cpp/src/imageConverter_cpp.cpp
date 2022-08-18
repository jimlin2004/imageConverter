#include "imageConverter.h"


/*error code
0 -> no error
1 -> can not find file
*/
int imageConvert(const char* _path, const char* _output)
{
    cv::Mat _img = cv::imread(_path);
    if (_img.empty())
    {
        printf("can not find image in %s\n", _path);
        return 1;
    }
    cv::imwrite(_output, _img);
    return 0;
}