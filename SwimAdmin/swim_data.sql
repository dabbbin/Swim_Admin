INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('1', '������', '����������尭��');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('2', '������', 'ü����ȭ���Ͱ���');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('3', '������', '�ָ������尭��');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('4', '�տ켺', '���ϼ����尭��');

INSERT INTO emp (EMP_ID, EMP_NAME, EMP_CAREER)
VALUES ('5', '������', '���������尭��');

INSERT INTO class (CL_NAME, CL_DATE, CL_USERNUM, CL_LIMIT, CL_ID, EMP_ID, POOL_ID)
VALUES ('���Ƽ���', TO_DATE('2023-11-28', 'YYYY-MM-DD'), '0', '5', '1', '1', '1');

INSERT INTO class (CL_NAME, CL_DATE, CL_USERNUM, CL_LIMIT, CL_ID, EMP_ID, POOL_ID)
VALUES ('�ʱ޼���', TO_DATE('2023-11-28', 'YYYY-MM-DD'), '0', '5', '2', '2', '2');

INSERT INTO class (CL_NAME, CL_DATE, CL_USERNUM, CL_LIMIT, CL_ID, EMP_ID, POOL_ID)
VALUES ('�߱޼���', TO_DATE('2023-11-28', 'YYYY-MM-DD'), '0', '5', '3', '3', '3');


INSERT INTO pool (POOL_ID, POOL_DIV)
VALUES ('1', '����Ǯ');

INSERT INTO pool (POOL_ID, POOL_DIV)
VALUES ('2', '�ʱ�Ǯ');

INSERT INTO pool (POOL_ID, POOL_DIV)
VALUES ('3', '�߱�Ǯ');

insert into member values('2023-11-23', '�����',1, '���', '010-3333-3333', '001101' )
/
insert into member values('2023-10-10', '�迵��',2, '����', '010-2525-3333', '001102'  )
/
insert into member values('2023-09-15', '�迵��',3, '����', '010-3333-2424', '001103'  )
/
insert into member values('2023-05-11', '�����',4, '���', '010-6060-3333', '001104'  )
/
insert into member values('2022-03-11', '������',5, '���', '010-3737-3333', '001105'  )
/
