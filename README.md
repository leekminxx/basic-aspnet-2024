# basic-aspnet-2024
IoT 개발자과정 ASP.NET 리포지토리


## 1일차
- 웹기술 개요
    -  World Wide Web 은 인터넷의 한 파트
    -  Full-Stack
        -  Fornt-end : 웹사이트 화면으로 사람들에게 보이는 부분
        -  Back-end : 웹사이트 뒤에서 동작하는 서버기술
        -  Server-Operation : HW, OS , SW 등 운영(클라우드)

- 업무용 웹 사이트 참조
    - hrrps://www.ecount.com/

- Front-end
    - HTML
    - CSS
    - Javascript

- Back-end
    1. Java -Spring, Spring, Boot, JSP ...
    2. Javascript - Node.js , Express ...\6.
    3. Python - dJango, Flask, fastAPi, ...
    4. C# - ASP,NEt 
    5. Rudy - Rudy on rails
    6. C - cgi, fasCGI ...
    7. PHP 

- 개발
    - 프론트엔드 전부 + 백엔드 여러개 중 하나 + DB
    - 웹 브라우저에서 F12(개발자도구)
    - VS Code 플러그인
        - HTML Code Snippet

- HTML5
    - XML이 웹페이지 구성하기 위한 선행기술, 너무 복잡해서 간략화 시킨 것
    - Hyper Text Markup Language
    - 기본적으로 확장자는 (.html)
    - tip! lorem 탭 , 긴 샘플텍스트 생성
    - 기본태그 (body에 사용)
        - h1 ~ h6 : 제목(마크다운 #, ##와 동일)
        - p : 일반문장
        - div : 그룹화 구분자 , 아주 중요(CSS 연계 디자인)
        - img : 이미지 표현
        - br : 한줄 내리기(엔터)
        - hr : 가로선
        - 특수문자 : & ; 사이에 영문자로 표시 ( 너무 많음!) 
        - strong 또는 b : 볼드체
        - em : 이탤릭체
        - mark : 형광펜 효과
        - small , sub , sup : 글자 작게 , 아래첨자 , 윗첨자 
        - u, strike : 밑줄 , 취소선
        - a : 웹페이지 링크(중요!)
        - ul, ol(목록) :  순서없는 목록(ul) 순번있는 목록(ol)
        - table, tr, th, th : 테이블 만드는 태그
        - audio , video : 오디오, 비디오
        - object, embed : 객체 추가
    
    - HTML + CSS + Javascript
        - 내부스타일 , 외부 스타일 , 인라인 스타일
        = 내부스크립트 , 외부 스크립트 , 인라인 스크립트

    - 오류 , 디버그
        - F12 개발자도구로 사용

    - 양식태그(body > from안에 사용 필수)
        - front-end 입력한 내용이 back-end 로 보내기위한 관문
        - from 을 반드시 사용
        - input 
            - type = "text"  : 텍스트박스
            - type = "password" : 비밀번호박스
            - type = 'button'  : 일반버튼
            - type =  'summit' : 제출(!)
            - radio = 라디오버튼
            - file : 파일 업로드
            - image : 이미지 (img 와 유사)
            - reset : 폼내의 입력양식태그 값 초기화
            - hidden : 숨김값(유효하게 사용!!!)
        - textarea : 여러행 텍스트 입력
        - select , 
        - select : 콤보박스 
        - filedset : 그룹박스
        - submit 클릭 loopback (값 전달) 발생
        - 값 전달 방식 
            - GET : URL뒤에 ? 다음에 키와  key = value&key = value ... 데이터 전달 
            - POST : 화면뒤로 숨겨서 데이터 전달 방식
    
    - 공간부분 태그
        - span - 한줄로 공간구성
        - div - 행간으로 블록지정 공간구성

## 2일차
- HTML5
    - 시맨틱 태그 - 시맨틱 태그로 화면을 구조를 잡는 웹구성 방식
        - header, nav, foother, aside, section, article....태그 사용
- CSS3
    - 웹 디자인 핵심, Casting Style Sheets
    - 상단에서부터 <body> 부터 하위에 태그들에 계속해서 적용되는 스타일이라는 뜻
    - 선택자에게 주어지는 디자인 속성
    - 선택자(selector)
    - 속성(property)
    - 배경 , 폰트 ...
    - 레이아웃
        - HTML 만으로는 화면 레이아웃이 만들어지지 않음
        - 중앙정렬, 원트루 , 고정바...
    - 반응형 웬(Responsive Web)
        - 메타태크 viewport를 사용하면 그때부터 반응형 웹이 됨!!
        ```html
        <meta name='viewport' content='width=device-width, initial-scale=1'
        ````
        -@meida 태그: 디바이스 종류별로 CSS 따로 디자인가능

        
- Javascript
    - 스크립트 언어, EMSScript
    - 웹 브라우저 주로 사용
    - 바닐라스크립트: 완벽하게 기본에 충실한 자바스크립트
    - 기본적으로 클라이언트(웹 브라우저에서 프론트엔드에 표시) 베이스
    - Node.js: 자바스크립트로 백엔드를 구현(파이썬과 유사)
    
    - 특징
        - 인터프리터 언어(not Compile Lang)
        - 속도가 컴파일 언어에 비해서 느림.
        - [중요!] HTML 태그와 연계(DOM)
        - 확장자 .js
            - VS Code도 자바스크립트로 만든 앱
        
        - 자료형 선언이 없음. var 변수 선언
        - let(일반/전역변수), var(지역변수), const(상수) 
        - **정수와 실수 구분 x**
            - 0으로 나눠도 예외가 발생하지 않음
        - '(홑따옴표)와 "(쌍따옴표) 모두 사용
        - 문장 끝 ; (세미콜론) 생략가능, but 최대한 쓸 것
        - === : 완전히 동일함을 비교하는 연산자
        - 변수 선언시 let(일반) , var(지역변수) , const(상수)
        - HTML 태그와 연계(DOM) 중요!!!
    
    - DOM(Document Object Model)!!!
        - 실행 순서!
        - HTML에 있는 모든 요소를 제어할 수 있음
        - HTML 애니메이션 , 게임 , 통신 모두가능
        - 이벤트 on - 으로 시작
            - onload : 화면이 다 랜더링되면 그 다음 발생 
            - onfocus : 객체에 마우스를 클릭해서 포커스가 가면 발생
            - onclick : 객체를 마우스로 클릭하면 발생
            - onbclick : 더블클릭 
            - onmousemove : 마우스를 이동하면 발생
            - onmousemove : 객체 위에 마우스가 올라가면 발생
            - onkeydown , onkeypress : 객체에서 키보드를 타이핑하면 발생
            - ...

    - jQuery
        - 자바스크립트 라이브러리
        - js를 매우 편리하게 사용할 수 있도록 도와주는 서포트 라이브러리
        - 순식간에 웹개발 업계를 장악했던 라이브러리
        - 사용빈도가 줄고는 있지만 아직도 80% 웹사이트가 사용 중 
        - js 파일 다운로드 후 사용하거나 
        - CDN 링크를 사용하는방법(추천)

## 4일차(2024-06-03)
- HTML + CSS + js(jQuery) 응용
    - jQuery 응용
        - javascript와 jQuery를 혼용해도 상관없음
        - jQuery로 코딩편할때와 javascript가 편할때도 있음

    - Bootstrap
        - 오픈소스 CSS 프레임워크
        - 트위터 블루프린트 -> 부트스트랩
        - 현재 전세계에서 가장 각광받는 프레임워크 중 하나
        - CSS를 동작시키기 위해서 Javascript도 포함
        - 소스 다운로드 받아서 사용(1), CDN으로 링크만 사용(2)
            - 제한된 네트워크에서는 1번
            - 인터넷에 항상 연결된 환경에서는 2번이 편리
        - 핵심!
            - Bootstrap은 화면사이즈를 12등분!
                - 12를 넘어서면 디자인이 깨짐!!!!
            - containter 및에 마치 table처럼 div를 구분해서 사용
            - container > row > col div 태그 클래스 정의
        - 부트스트랩 학습에 시간을 들이는 게 아님. Copyleft가 정석!
            - https://getbootstrap.com/docs/5.3/getting-started/introduction/ 참조
            - https://getbootstrap.com/docs/5.3/examples/ 스니펫을 활용 추천
        - 무료 테마(템플릿)가 아주 잘되어 있음
            - https://startbootstrap.com/
    - 웹페이지 클로닝
        - 핀터레스트 타입 + 부트스트랩 웹페이지 만들기(진행중)

## 5일차
- HTML + CSS + js(jQuery) 응용
    - 웹페이지 클로닝
        - 핀터레스트 타입  핀터레스트 타입 웹페이지 만들기(완료)

            https://github.com/leekminxx/basic-aspnet-2024/assets/158007500/d858dd93-5c90-4e67-913d-e55c5b8a88df
       
        - Codehal 유튜버 로그인 웹페이지 튜토리얼 따라하기

            <img src="https://raw.githubusercontent.com/leekminxx/basic-aspnet-2024/main/images/an0001.png" width="730" alt="Codehal 로그인창 따라하기">
        
        - Codehal 슬라이더 애니메이션 웹페이지 튜토리얼 따라하기 

## 6일차
- HTML + CSS + js(jQuery) dmddyd
    - 웹페이지 클로닝 
        - Codehal 슬라이더 애니메이션 웹페이지 튜토리얼 따라하기 (완료)
   


            https://github.com/leekminxx/basic-aspnet-2024/assets/158007500/c0daeb31-e5f3-47b5-a092-e03588668941



- 개인 웹페이지 클로닝

    - HTML , CSS , JavaScript를 사용한 반응형 애니메이션 제품카드 튜토리얼 만들기
        - 프로젝트 개요 : Nike 신발 제품의 상세 정보를 보여주는 웹페이지
            다양한 색상과 크기를 선택할 수 있으며 , 선택한 색상에 따라 제품이미지와 배경색상이 변경됨 

        - 주요 기능 
        1. 색상 선택기능 : 사용자가 선택한 색상에 따라서 신발이미지와 배경 그라데이션 효과를 적용해 색상변경을 보여줌
        2. 크기 선택 기능 : 사용자가 선택한 신발 크기를 강조하여 표시
        3. 반응형 디자인 : 다양한 화면 크기에 맞추어 레이아웃이 조정됨

    - 기능적 부분 
        - HTML
            - container 클래스는 페이지 전체를 감싸고 중앙에 정렬합니다.
            - card 클래스는 제품 정보를 담고 있습니다.
            - shoeBackground 클래스는 배경과 신발 이미지를 포함합니다.
            - info 클래스는 제품 정보, 설명, 색상 선택, 크기 선택, 가격 및 구매 버튼을 포함합니다.
            - 신발 이미지 (.shoe)는 여러 색상 버전이 포함됩니다.
            - 색상 선택 요소 (.color)는 각 색상에 대해 정의됩니다.
            - 크기 선택 요소 (.size)는 각 신발 크기에 대해 정의됩니다.

        - CSS

            - 기본스타일
                - 모든 요소는 기본적으로 마진과 패딩을 0으로 설정하고, box-sizing을 border-box로 설정합니다.
                  body는 연한 회색 배경색 (#efefef)으로 설정합니다.
                  font-family는 'Poppins'로 설정합니다.

            - 레이아웃
                - container는 화면의 중앙에 컨텐츠를 배치합니다.
                - card는 가로로 정렬되어 있으며, 화면이 좁아지면 세로로 정렬됩니다.

            - 제품 이미지 및 배경
                - .shoeBackground는 신발 이미지를 배경 그라데이션과 함께 표시합니다.
                - .gradients와 .gradient 클래스를 통해 다양한 색상의 그라데이션을 설정합니다.
                - 선택된 색상에 따라 first와 second 클래스를 사용해 배경 전환 애니메이션을 적용합니다.

            - 색상 및 크기 선택
                - .color 클래스는 선택 가능한 색상 옵션을 둥근 버튼으로 표시합니다.
                - .size 클래스는 선택 가능한 신발 크기를 사각형 버튼으로 표시합니다.
                - 선택된 옵션은 active 클래스를 통해 강조됩니다.

            - 반응형 디자인
                - 다양한 화면 크기에서 적절한 레이아웃을 유지하기 위해 미디어 쿼리를 사용합니다.

        - JavaScript

            - 기본설정
                - DOMContentLoaded 이벤트를 사용해 DOM이 완전히 로드된 후 스크립트를 실행합니다.
            - 색상 선택 기능
                - colors 변수에 모든 색상 요소를 선택합니다.
                - shoes 변수에 모든 신발 이미지 요소를 선택합니다.
                - gradients 변수에 모든 그라데이션 요소를 선택합니다.
                - removeActive 함수는 모든 요소에서 'active' 클래스를 제거합니다.
                - changeColor 함수는 선택된 색상에 따라 신발 이미지와 배경 그라데이션을 변경합니다.
                - 각 색상 요소에 클릭 이벤트 리스너를 추가해 선택된 색상에 따라 changeColor 함수를 호출합니다.

        - 가로모드

          https://github.com/leekminxx/basic-aspnet-2024/assets/158007500/65fadf02-548a-4c2c-82c9-d4b7d268ecba

        - 모바일 세로모드
      


          https://github.com/leekminxx/basic-aspnet-2024/assets/158007500/75e7473c-79e4-484a-acf6-225a0a5980db


## 8일차
- ASP.NET
    - ASP.NET 역사
        - 1990년대 MS가 웹 서버기술로 ASP(Active Server Page)를 배포. like JSP(Java Server Page)
        - ASP는 .NET으로 된 언어가 아닌, VBScript를 사용. 확장자(.asp)
        - 개발이 무지 쉬워서 많이 사용
        - 스파게티 코드! - HTML + CSS + javascript + VBsript 짬뽕으로 만든 웹 페이지
        - 유지보수 어렵고 , 성능이 나쁘고...

        - 2000년대 MS가 .NET을 발표.
        - C#, VB.NET, C++.NET 등의 새로운 언어를 배포, 여기에 맞춰서 웹 서버기술을 다시 만듬 -> ASP.NET(.aspx)
        - 가장 큰 장점은 윈폼 개발하는 것 처럼 웹개발을 할 수 있었음.
        - 초창기에 스파게티 코드를 거의 그대로 사용 성능도 안좋고..
        - 2009년 ASP.NET MVC(Model View Controller 디자인패턴) 공표. 성능은 좋아짐.
        - 하지만, 윈도우에서만 동작 
        - 2016년 모든 OS플랫폼에서 동작할 수 있는 .NET Core를 재출시
        - 거기에 웹 서버기술을 또 다시 만듦 -> ASP.NET Core

    - .NET Core(현재는 .NET 9.0, Core라는 이름은 사용안함)의 장점
        - 빠르고 오픈소스
        - 크로스 플랫폼 , OS에 종속받지 않음
        - 성능!
    
    - ASP.NET Core
        - ASP.NET Webforms  2000년도 초반에 나오다가 시장된 웹사이트 개발기술
        - **ASP.NET Core  웹앱(MVC) - 가장 기본적인 프론트엔드(HTML,CSS,JS (.cshtml확장자)) + 백엔드(C# .aspx.cs) 웹개발**
        - **ASP.NET Core 웹 API - 데이터포털, 네이버 , 카카오 , 영화 API 사이트를 만드는 백엔드(프론트엔드가 없어서 화면이 없음)**
        - Js(Vue, Angular, React) 프론트엔드 + ASP.NET Core 백엔드
        - Edge용 웹 드라이버 테스트 - 엣지 브라우저에 종속된 테스트용 프로젝트
        - ASP.NET Cor gRPC 서비스 - 고성능 원격프로시저호출(스트리밍 호출) 서비스
        - Blazor - js 프론트엔드를 따라서 C# 컴포넌트 기반으로 개발하는 웹개발 방식 웹사이트 개발
        - Razor - 프론트엔드 개발에 C# 코드가 특화되서 사용되는 웹사이트 개발방식
        - .NET Aspire - Blazor 프론트엔드 + Redis + 웹 APO 백엔드
    
    - 참조사이트
        - https://learn.microsoft.com/ko-kr/aspnet/core/?view=aspnetcore-3.1
        - https://github.com/dotnet
        - https://mixedcode.com/
        - https://github.com/gilbutITbook/006824

    - ASP.NET Core 웹앱(Model-View-Controller)
        - 현재 기본적인 웹개발의 가장 표준
        - Java 계열도 Spring (Boot) MVC로 개발 
        - MVC 개념도

        <img src="https://raw.githubusercontent.com/leekminxx/basic-aspnet-2024/main/images/an0002.png" width="730">

        - 프론트엔드가 예전에 스파게티코드가 무지 심했다면 , 현재는 스파게티코드가 최소화 되어있음.(SpringBoot Python flask든 모두 동일)
        - IIS Express Server - VS에서 ASP.NET 웹사이트를 운영하는 개발용 웹서버 
        - index.* - 웹사이트 가장 대문되는 페이지이름
        - 파일 저장시 핫다시로드(HotReload) 체크
        - @로 시작하는 C# 구문. Tag helper, Html helper 로 HTML 구문 내에 C# 코드를 적어서 활용하는 방법 = Razor 구문
        - Action == HTMl 에서 form 태그내 submit버튼 클릭! / 링크를 클릭
        - 액션이 발생한 이후 처리하는 메서드의 결과를 ActionResult
        - 콘솔 서버로그 잘 확인할 것 , 프로세스가 종료되면 웹사이트가 실행안됨 
    
    - 테이터베이스 연동방법
        - DB first - 가장 전통적인 DB 연동방식. DB설계, DB구축, C#과 연동
        - Code first - 최근 트랜드가 되는 DB 연동방식. C#클래스 작성, DB연결 설정 후 실행하면 DB에 테이블이 생성...
        - EntityFramework를 사용하면 아주 손쉽게 구축가능
    
    - EntityFramework(Core) 설치
        - Microsoft.EntityFrameworkCore.
        - Microsoft.EntityFrameworkCore.Tools
        - Microsoft.EntityFrameworkCore.SqlServer

    - Code first 구현순서 
        - ASP.NET 프로젝트 생성
        - EF 패키지 설치
        - 엔티티 클래스 작성
        - appsettings.json 에 DB연결문자열 추가 
        - Data/ApplicationDbContext.cs 중간연결 클래스 생성
        - Program.cs Services 내에 DbContext
        - NuGet 패키지 관리자 > 패키지 관리자 콘솔 실행
            ```shell
            PM> add-migration 마이그레이션명
            Build started...
            Build succeeded.
            ...
            PM> update-database
            ...
            Done.
            ```
## 9일차 (07.22)
- ASP.NET Core MVC
    - 필요 이론
    - 연습
    - 개인 포트폴리오 웹사이트
    - Bootstrap 테마 적용