# CMAKE generated file: DO NOT EDIT!
# Generated by "MinGW Makefiles" Generator, CMake Version 3.24

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:

#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:

# Disable VCS-based implicit rules.
% : %,v

# Disable VCS-based implicit rules.
% : RCS/%

# Disable VCS-based implicit rules.
% : RCS/%,v

# Disable VCS-based implicit rules.
% : SCCS/s.%

# Disable VCS-based implicit rules.
% : s.%

.SUFFIXES: .hpux_make_needs_suffix_list

# Command-line flag to silence nested $(MAKE).
$(VERBOSE)MAKESILENT = -s

#Suppress display of executed commands.
$(VERBOSE).SILENT:

# A target that is always out of date.
cmake_force:
.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

SHELL = cmd.exe

# The CMake executable.
CMAKE_COMMAND = "C:\Program Files\CMake\bin\cmake.exe"

# The command to remove a file.
RM = "C:\Program Files\CMake\bin\cmake.exe" -E rm -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = D:\code\cpp\imageConverter_cpp_cmake

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = D:\code\cpp\imageConverter_cpp_cmake\build

# Include any dependencies generated for this target.
include CMakeFiles/imageConverter_cpp.dir/depend.make
# Include any dependencies generated by the compiler for this target.
include CMakeFiles/imageConverter_cpp.dir/compiler_depend.make

# Include the progress variables for this target.
include CMakeFiles/imageConverter_cpp.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/imageConverter_cpp.dir/flags.make

CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.obj: CMakeFiles/imageConverter_cpp.dir/flags.make
CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.obj: D:/code/cpp/imageConverter_cpp_cmake/src/imageConverter_cpp.cpp
CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.obj: CMakeFiles/imageConverter_cpp.dir/compiler_depend.ts
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=D:\code\cpp\imageConverter_cpp_cmake\build\CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.obj"
	$(CMAKE_COMMAND) -E cmake_cl_compile_depends --dep-file=CMakeFiles\imageConverter_cpp.dir\src\imageConverter_cpp.cpp.obj.d --working-dir=D:\code\cpp\imageConverter_cpp_cmake\build --filter-prefix="??????: ????????????: " -- C:\PROGRA~1\MIB055~1\2022\COMMUN~1\VC\Tools\MSVC\1432~1.313\bin\Hostx64\x64\cl.exe  /nologo /TP $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) /showIncludes /FoCMakeFiles\imageConverter_cpp.dir\src\imageConverter_cpp.cpp.obj /FdCMakeFiles\imageConverter_cpp.dir/ /FS -c D:\code\cpp\imageConverter_cpp_cmake\src\imageConverter_cpp.cpp

CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.i"
	C:\PROGRA~1\MIB055~1\2022\COMMUN~1\VC\Tools\MSVC\1432~1.313\bin\Hostx64\x64\cl.exe > CMakeFiles\imageConverter_cpp.dir\src\imageConverter_cpp.cpp.i  /nologo /TP $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E D:\code\cpp\imageConverter_cpp_cmake\src\imageConverter_cpp.cpp

CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.s"
	C:\PROGRA~1\MIB055~1\2022\COMMUN~1\VC\Tools\MSVC\1432~1.313\bin\Hostx64\x64\cl.exe  /nologo /TP $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) /FoNUL /FAs /FaCMakeFiles\imageConverter_cpp.dir\src\imageConverter_cpp.cpp.s /c D:\code\cpp\imageConverter_cpp_cmake\src\imageConverter_cpp.cpp

# Object files for target imageConverter_cpp
imageConverter_cpp_OBJECTS = \
"CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.obj"

# External object files for target imageConverter_cpp
imageConverter_cpp_EXTERNAL_OBJECTS =

imageConverter_cpp.dll: CMakeFiles/imageConverter_cpp.dir/src/imageConverter_cpp.cpp.obj
imageConverter_cpp.dll: CMakeFiles/imageConverter_cpp.dir/build.make
imageConverter_cpp.dll: D:/cpp_lib/opencv/build/x64/vc15/lib/opencv_world460.lib
imageConverter_cpp.dll: CMakeFiles/imageConverter_cpp.dir/objects1.rsp
imageConverter_cpp.dll: CMakeFiles/imageConverter_cpp.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=D:\code\cpp\imageConverter_cpp_cmake\build\CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX shared library imageConverter_cpp.dll"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles\imageConverter_cpp.dir\link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/imageConverter_cpp.dir/build: imageConverter_cpp.dll
.PHONY : CMakeFiles/imageConverter_cpp.dir/build

CMakeFiles/imageConverter_cpp.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles\imageConverter_cpp.dir\cmake_clean.cmake
.PHONY : CMakeFiles/imageConverter_cpp.dir/clean

CMakeFiles/imageConverter_cpp.dir/depend:
	$(CMAKE_COMMAND) -E cmake_depends "MinGW Makefiles" D:\code\cpp\imageConverter_cpp_cmake D:\code\cpp\imageConverter_cpp_cmake D:\code\cpp\imageConverter_cpp_cmake\build D:\code\cpp\imageConverter_cpp_cmake\build D:\code\cpp\imageConverter_cpp_cmake\build\CMakeFiles\imageConverter_cpp.dir\DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/imageConverter_cpp.dir/depend

