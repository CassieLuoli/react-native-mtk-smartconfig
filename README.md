
# react-native-mtk-smartconfig

## Getting started

`$ npm install react-native-mtk-smartconfig --save`

### Mostly automatic installation

`$ react-native link react-native-mtk-smartconfig`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-mtk-smartconfig` and add `RNMtkSmartconfig.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNMtkSmartconfig.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.mtk.smartconfig.RNMtkSmartconfigPackage;` to the imports at the top of the file
  - Add `new RNMtkSmartconfigPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-mtk-smartconfig'
  	project(':react-native-mtk-smartconfig').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-mtk-smartconfig/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-mtk-smartconfig')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNMtkSmartconfig.sln` in `node_modules/react-native-mtk-smartconfig/windows/RNMtkSmartconfig.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Mtk.Smartconfig.RNMtkSmartconfig;` to the usings at the top of the file
  - Add `new RNMtkSmartconfigPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNMtkSmartconfig from 'react-native-mtk-smartconfig';

// TODO: What to do with the module?
RNMtkSmartconfig;
```
  