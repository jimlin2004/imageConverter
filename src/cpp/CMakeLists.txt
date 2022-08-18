cmake_minimum_required(VERSION 3.0.0)
project(imageConverter_cpp VERSION 0.1.0)

include(CTest)
enable_testing()

set(OpenCV_DIR "D:/cpp_lib/opencv/build/x64/vc15/lib")
find_package(OpenCV REQUIRED)
include_directories("D:/cpp_lib/opencv/build/include")
# add_library(imageConverter_cpp imageConverter_cpp.cpp)

file(GLOB_RECURSE SRC_FILE src/*.cpp)
add_library(imageConverter_cpp SHARED src/imageConverter_cpp.cpp)
# add_executable(imageConverter_cpp main.cpp ${SRC_FILE})
target_link_libraries(imageConverter_cpp "D:/cpp_lib/opencv/build/x64/vc15/lib/opencv_world460.lib")
target_include_directories(imageConverter_cpp PRIVATE ${CMAKE_CURRENT_SOURCE_DIR}/include)

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)
