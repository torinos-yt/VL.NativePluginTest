PLATFORM = Windows
OUTPUT_TYPE = dll

TOOLCHAIN = x86_64-w64-mingw32
CXX = $(TOOLCHAIN)-c++
STRIP = $(TOOLCHAIN)-strip

#
# File listings
#

TARGET = TestPluginNative
SRCS = test.cpp
OUT_DIR = ../../lib/native

#
# Intermediate/output files
#

OBJS = $(SRCS:.cpp=.o)
OUTPUT = $(TARGET).$(OUTPUT_TYPE)

#
# Compiler/linker options
#

CXXFLAGS += -O2 -Wall -std=c++11
LDFLAGS += -shared

#
# Building rules
#

$(TARGET).dll: $(OBJS)
	$(CXX) $(LDFLAGS) -o $@ $^
	$(STRIP) $@
	cp -f $(OUTPUT) $(OUT_DIR)/$(OUTPUT)
	rm -f $(OUTPUT) $(OBJS)

.cpp.o:
	$(CXX) $(CXXFLAGS) -c -o $@ $<