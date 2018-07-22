#!/usr/bin/env bash

export ANDROID_SDK_ROOT=/Users/luiz/Library/Android/sdk
export ANDROID_HOME=/Users/luiz/Library/Android/sdk

export PATH=$PATH:$ANDROID_HOME/tools
export PATH=$PATH:$ANDROID_HOME/platform-tools

adb logcat *:S ReactNative:V ReactNativeJS:V BackgroundTask:V





