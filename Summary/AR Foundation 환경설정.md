# [AR Foundation 환경설정]

AR 개발 전에 미리 세팅해야 하는 내용을 정리하였다.

## [Package Manager]

Window -> Package Manager -> Packages: Unity Registry 에서  
  
AR을 검색하여 `AR Foundation`을 설치한다.  
또한 Android를 타겟으로 한 경우 `ARCore XR Plugin` 을 설치하고  
iOS를 타겟으로 한 경우 `ARKit XR Plugin`을 설치한다. 

## [Build Settings]

* File -> Build Settings -> Android -> switch platform 탭

* Player Settings -> Graphics APIs -> Vulkan 제거
* Player Settings -> Minimum API level - 24이상 선택

* Project Settings -> XR Plug-in Management -> platform 선택 -> 사용할 Plug-in 선택

## [AR Scene 세팅]

* XR - AR Session 추가  
(AR의 LifeCycle을 비롯하여 전반적인 내용을 관리하는 역할을 한다.) 
* XR - AR Session Origin 추가  
(기준점이자 카메라의 위치가 되는 오브젝트이다.)
* Main Camera 삭제
* AR Camera -> Tag -> Main Camera 로 설정 

### [참고 링크]
* https://www.youtube.com/watch?v=gi9iHTY9z1o&t=3s 