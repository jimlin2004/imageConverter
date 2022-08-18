#ifndef IMAGECONVERTER_CPP_H
#define IMAGECONVERTER_CPP_H

#include <opencv2/imgcodecs.hpp>
#include <stdio.h>

extern "C"
{
    __declspec(dllexport) int __stdcall imageConvert(const char* path, const char* type);
}

#endif