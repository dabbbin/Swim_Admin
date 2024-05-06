
# 🏊‍♀️ 수영강습 관리자용 프로그램

## 🤽 프로젝트 소개
* 개발기간 : 2023.09.14 - 2023.12.07 (85일)
* 회원 정보를 입력하고 관리자 계정을 이용해 회원별 강습 관리와 강사를 관리하는 시스템입니다.
* 회원 여러 명의 정보를 입력받을 수 있으며 강습과 강사 또한 조회/수정/삭제가 가능합니다.
* 🔗[SWIM 팀 스터디 기록]()

## 🧑‍💻팀원 구성

1. ⭐️ 정보경 ()
2. 김다빈 (dabbbin)
3. 박세연 ()

## 🛠️개발 환경
* Develop : C#
* Communicate : Discord, Figma


## 프로젝트 구조
```
└─SwimAdmin
    │  SwimFlow.sln
    │  swim_data.sql
    │  수영장스크립트최종.sql
    │  
    ├─.vs
    │  │  slnx.sqlite
    │  │  VSWorkspaceState.json
    │  │  
    │  ├─ADOForm_ver2
    │  │  └─v16
    │  ├─SwimAdmin
    │  │  └─v16
    │  └─SwimFlow
    │      ├─FileContentIndex
    │
    │      ├─v15
    │        └─Server
    │           └─sqlite3    
    └─ADOForm
        │  AdminForm.cs
        │  AdminForm.Designer.cs
        │  AdminForm.resx
        │  App.config
        │  ClassForm.cs
        │  ClassForm.Designer.cs
        │  ClassForm.resx
        │  DBClass.cs
        │  EmpForm.cs
        │  EmpForm.Designer.cs
        │  EmpForm.resx
        │  InfoForm.cs
        │  InfoForm.Designer.cs
        │  InfoForm.resx
        │  MDIMain.cs
        │  MDIMain.Designer.cs
        │  MDIMain.resx
        │  MemberForm.cs
        │  MemberForm.Designer.cs
        │  MemberForm.resx
        │  Program.cs
        │  RegisterForm.cs
        │  RegisterForm.designer.cs
        │  RegisterForm.resx
        │  StartForm.cs
        │  StartForm.Designer.cs
        │  StartForm.resx
        │  SwimForm_ver3_2025.csproj
        │  SwimForm_ver3_2025.csproj.user
        │  UserclassSearch.cs
        │  UserclassSearch.Designer.cs
        │  UserclassSearch.resx
        │  
        ├─bin
        │  ├─Debug
        │  │      
        │  └─Release
        ├─obj
        │  ├─Debug
        │  │  │  
        │  │  └─TempPE         
        │  └─Release       
        └─Properties

```
<br>

## 📋역할 분담

#### ⭐️ 정보경
* RegisterForm
  1. 수강신청 및 수강강의 조회 기능 구현

#### 김다빈
* AdminForm
  1. 관리자페이지 관리 
 
* MemberForm
  1. 회원정보 관리 페이지
 
* StartForm
 
#### 박세연
* EmpForm
  1. 강사 및 강습 관리 기능 개발
  2. 강사 및 강습 검색 기능 구현

## 📕 프로젝트 후기

#### ⭐️ 정보경
* 라이브러를활용해 db연동을 해 본 경험은 있었지만 직접 데이터베이스를 연결해본 경험은없었습니다. 이번 수업을 통해 db연동을 하는 경험을 통해 앞으로 개발환경을 구축하는데 많은 도움을 받을 수 있을 것이라고 기대합니다.

#### 김다빈
* ERD 설계부터 연동, DB 구축까지 전 과정을 직접 개발할 수 있어서  좋은 경험이었습니다. 이를 더 보완해서 새로운 프로젝트에 투입되었을 때, 시스템의 성능을 향상시키고 DB 구축에 신경쓰는 더 나은 개발자가 될 수 있을 것이라 기대합니다.  

#### 박세연
* 데이터베이스를 이론으로만 공부했었는데 이번 기회에 주제 선정, 기획부터 DB설계와 구축, 기능 구현까지 직접 경험해 볼 수 있어 매우 뜻깊은 시간이었습니다. 또한, 팀원들과 함께 프로젝트를 진행하면서 사람들과 협업하는 과정을 배워갈 수 있는 값진 경험을 하였습니다.



