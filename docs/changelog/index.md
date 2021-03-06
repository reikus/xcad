---
title: List of changes in the releases of xCAD.NET framework
caption: Changelog
description: Information about releases (new features, bug fixes breaking changes) of xCAD.NET framework for developing CAD applications
order: 8
---
This page contains list of the most notable changes in the releases of xCAD.NET.

Breaking change is marked with &#x26A0; symbol

## 0.6.8 - November, 10 2020

* Added tags support for IXDocument to store custom user data within the session
* Added the IXPart::CutListRebuild event

## 0.6.7 - November, 9 2020

* &#x26A0; All SOLIDWORKS specific classes replaced with corresponding interfaces with I at the start (e.g. SwApplication -> ISwApplication, SwDocument -> ISwDocument)
* &#x26A0; IXDocumentRepository::Open is replaced with transaction (also available as extension method) and **DocumentOpenArgs** is retired.
* &#x26A0; IXModelViewBasedDrawingView::View is renamed to IXModelViewBasedDrawingView::SourceModelView
* &#x26A0; IXCircularEdge::Center, IXCircularEdge::Axis, IXCircularEdge::Radius are replaced with IXCircularEdge::Definition
* &#x26A0; IXLinearEdge::RootPoint, IXLinearEdge::Direction are replaced with IXLinearEdge::Definition
* &#x26A0; IXGeometryBuilder is changed and available via IXApplication::MemoryGeometryBuilder
* Added support for extrusion, sweep, revolve for memory IXGeometryBuilder
* Added partial support for surfaces and curves as definitions for edges and faces
* Added partial support for sketch entities in the sketch

## 0.6.6 - October, 29 2020

* Implemented [#36 - Add ability to configure services for dependency injection](https://github.com/xarial/xcad/issues/36)
* Implemented [#37 - Add options to add colors to faces, bodies and features](https://github.com/xarial/xcad/issues/37)
* Implemented [#38 - Add support for drawing views](https://github.com/xarial/xcad/issues/38)
* Implemented [#39 - Add ability to read feature tree from IXComponent](https://github.com/xarial/xcad/issues/39)
* Fixed [#40 - SwAssembly.Components returns empty enumerable in add-in bug](https://github.com/xarial/xcad/issues/40)
* Fixed [#41 - IXSelectionRepository::Add fails if other objects were preselected bug](https://github.com/xarial/xcad/issues/41)
* &#x26A0; IXProperty::Exists moved to an extension method instead of property
* &#x26A0; IXDocument3D::ActiveView moved to IXDocument3D::Views::Active
* &#x26A0; IXDocumentCollection renamed to IXDocumentRepository

## 0.6.5 - October, 14 2020

* Implemented [#33 - Add event when extension and host application is fully loaded](https://github.com/xarial/xcad/issues/33)
* Implemented [#34 - Add WindowRectangle API to find the bounds of the host window](https://github.com/xarial/xcad/issues/34)

## 0.6.4 - September, 30 2020

* Implemented [#30 - Add option to open document in rapid mode](https://github.com/xarial/xcad/issues/30)
* Fixed [#31 - INotifyPropertyChanged is ignored](https://github.com/xarial/xcad/issues/31)
* Switched SOLIDWORKS Interops to version 2020

## 0.6.3 - September, 30 2020

* Added exceptions for the macro running and document opening
* &#x26A0; Changed SwApplication::Start to be sync
* Implemented [#29 - IXDocumentRepository::Open should support all file types](https://github.com/xarial/xcad/issues/29) 

## 0.6.2 - September, 28 2020

* Fixed [#24 - Build error when cleaning the solution](https://github.com/xarial/xcad/issues/24)
* Implemented [#25 - Add IXApplication::Process](https://github.com/xarial/xcad/issues/25)

## 0.6.1 - September, 23 2020

* Fixed [#20 - BitmapButton bool not firing propertyManagerPage DataChanged Event](https://github.com/xarial/xcad/issues/20)
* Implemented [#21 - Add IXApplication::WindowHandle](https://github.com/xarial/xcad/issues/21)
* Implemented [#22 - Add SwApplication::GetInstalledVersion static method](https://github.com/xarial/xcad/issues/22)

## 0.6.0 - September, 13 2020

* Implemented [#5 - Updating Combobox based on another comboBox selection change](https://github.com/xarial/xcad/issues/5). Refer [help documentation](/property-pages/controls/combo-box#dynamic-items-provider) for more information

* Implemented [#6 - Add Support to Bitmap Button](https://github.com/xarial/xcad/issues/6)

* &#x26A0; Moved **Xarial.XCad.Utils.PageBuilder.Base.IDependencyHandler** to **Xarial.XCad.UI.PropertyPage.Services.IDependencyHandler**

* &#x26A0; Added second parameter **IControl[] dependencies** to **ICustomItemsProvider.ProvideItems** 

* &#x26A0; **IDependencyHandler.UpdateState** provides **IControl** instead of **IBinding**

## 0.5.8 - September, 1 2020

* Added new events:
    
    * IXConfigurationRepository.ConfigurationActivated
    * IXDocument.Rebuild, IXDocument.Saving
    * IXDocumentCollection.DocumentActivated
    * IXSheetRepository.SheetActivated

* Added new interfaces
    * IXSheet

* &#x26A0; Added parameter of **IXDocument** to **NewSelectionDelegate**

* Fixed the issue with toolbar positions not maintained after SOLIDWORKS restart

* &#x26A0; **state** parameter of **CommandStateDelegate** is no longer passed with **ref** keyword

## 0.5.7 - July, 19 2020

* Added support for TaskPane
* Added support for Feature Manager Tab

## 0.5.0 - June, 15 2020

* Added support for tabs and custom controls in property pages
* Added support for 3rd party storage and 3rd party stream
* Renamed to **StandardIconAttribute** to **StandardControlIconAttribute**

## 0.3.1 - February, 9 2020

* &#x26A0; Renamed **ControlAttributionAttribute** to **StandardIconAttribute**

## 0.2.4 - February, 6 2020

* Added **ICustomItemsProvider** to provide dynamic items for the ComboBox control in property pages

## 0.2.0 - February, 6 2020

* Added support for selections
* Added support for IXFace

## 0.1.0 - February, 4 2020

Initial Release