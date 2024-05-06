INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('1', '김정자', '삼육대수영장강사');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('2', '정정자', '체육문화센터강사');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('3', '박찬희', '주말수영장강사');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('4', '손우성', '평일수영장강사');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('5', '김자일', '별내수영장강사');

INSERT INTO class (CL_NAME, CL_DATE, CL_USERNUM, CL_LIMIT, CL_ID, EMP_ID, POOL_ID)
VALUES ('유아수영', TO_DATE('2023-11-28', 'YYYY-MM-DD'), '0', '5', '1', '1', '1');

INSERT INTO class (CL_NAME, CL_DATE, CL_USERNUM, CL_LIMIT, CL_ID, EMP_ID, POOL_ID)
VALUES ('초급수영', TO_DATE('2023-11-28', 'YYYY-MM-DD'), '0', '5', '2', '2', '2');

INSERT INTO class (CL_NAME, CL_DATE, CL_USERNUM, CL_LIMIT, CL_ID, EMP_ID, POOL_ID)
VALUES ('중급수영', TO_DATE('2023-11-28', 'YYYY-MM-DD'), '0', '5', '3', '3', '3');


INSERT INTO pool (POOL_ID, POOL_DIV)
VALUES ('1', '유아풀');

INSERT INTO pool (POOL_ID, POOL_DIV)
VALUES ('2', '초급풀');

INSERT INTO pool (POOL_ID, POOL_DIV)
VALUES ('3', '중급풀');

insert into member values('2023-11-23', '김수영',1, '경기', '010-3333-3333', '001101' )
/
insert into member values('2023-10-10', '김영수',2, '서울', '010-2525-3333', '001102'  )
/
insert into member values('2023-09-15', '김영자',3, '서울', '010-3333-2424', '001103'  )
/
insert into member values('2023-05-11', '김숙희',4, '노원', '010-6060-3333', '001104'  )
/
insert into member values('2022-03-11', '정찬희',5, '노원', '010-3737-3333', '001105'  )
/
