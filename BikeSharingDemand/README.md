# BikeSharingDemand
**메타버스 아카데미 1기  AI 전공 7월 팀 프로젝트**<br><br>

## 🚲 데이터 필드
https://www.kaggle.com/c/bike-sharing-demand
<br><br>
datetime: 연,월,일에 대한 시간 데이터<br>
season: 1 : spring , 2 = summer, 3 = fall, 4 = winter<br>
holiday: 공휴일, 주말(0:공휴일X 1:공휴일)<br>
workingday: 공휴일, 주말을 제외한 평일<br>
weather :<br>
1: 깨끗한 날씨, 아주 약간의 구름<br>
2: 흐림, 약간의 안개나 구름이 끼어있는 날씨<br>
3: 약간의 눈, 비, 천둥<br>
4: 아주 많은 눈, 비가 오거나 우박천둥<br>
temp: 기온<br>
atemp: 체감온도<br>
humidity: 습도<br>
windspeed: 바람의 세기<br>
casual: 비회원의 대여량<br>
registered: 회원의 대여량<br>
count: 총 대여량
<br><br>

## 📊 데이터 분석
![화면 캡처 2022-10-09 185906](https://user-images.githubusercontent.com/54497150/194750442-31c8bc8c-05e7-4c32-92f3-1e5c764f4052.png)
<br><br>

## 💡 모델 학습
![화면 캡처 2022-10-09 233336](https://user-images.githubusercontent.com/54497150/194763297-4fe9e7cd-7dfc-4bf4-b0ee-fe9ed8f032d4.png)
![화면 캡처 2022-10-09 233941](https://user-images.githubusercontent.com/54497150/194763301-13bed66b-d385-4398-8f42-377e7061a7a4.png)<br><br>
Best Model => LGBMRegressor<br>
Grid Search를 이용하여 최적 모델 찾기
<br><br>

## 👋 Contributors
- 박주희 @juliajh
- 박찬영 
- 이성빈 @naya-beene
- 최나영
