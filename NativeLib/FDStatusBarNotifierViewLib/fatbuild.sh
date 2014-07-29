#Universal Binary Build Script

XCODEBUILD_PATH=/Applications/Xcode.app/Contents/Developer/usr/bin
XCODEBUILD=$XCODEBUILD_PATH/xcodebuild
LIBNAME=${PWD##*/}

PROJECT_HOME=`pwd`
echo $PROJECT_HOME
OUTPUT_PATH=$PROJECT_HOME/build
echo $OUTPUT_PATH
echo $LIBNAME

$XCODEBUILD -target "$LIBNAME" -sdk "iphonesimulator" -configuration "Release" clean build
$XCODEBUILD -target "$LIBNAME" -sdk "iphoneos" -configuration "Release" clean build

rm -rf $OUTPUT_PATH/Release-universal
mkdir $OUTPUT_PATH/Release-universal
lipo -create $OUTPUT_PATH/Release-iphonesimulator/lib$LIBNAME.a $OUTPUT_PATH/Release-iphoneos/lib$LIBNAME.a -output $OUTPUT_PATH/Release-universal/lib$LIBNAME.a