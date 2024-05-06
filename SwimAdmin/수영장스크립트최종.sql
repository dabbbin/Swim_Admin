DROP TABLE admin;

CREATE TABLE admin
(
    admin_id    VARCHAR2(10) NOT NULL,
    admin_pw    VARCHAR2(10) NOT NULL,
    admin_name    VARCHAR2(10) NOT NULL
);

COMMENT ON COLUMN admin.admin_id IS '관리자id';

COMMENT ON COLUMN admin.admin_pw IS '관리자비밀번호';

COMMENT ON COLUMN admin.admin_name IS '관리자명';

COMMENT ON TABLE admin IS '관리자';

ALTER TABLE admin
 ADD CONSTRAINT admin_PK PRIMARY KEY (admin_id)
 USING INDEX admin_PK;

DROP INDEX admin_PK;

CREATE UNIQUE INDEX admin_PK ON admin
( admin_id );


DROP TABLE class;

CREATE TABLE class
(
    cl_name    VARCHAR2(15) NOT NULL,
    cl_date    VARCHAR2(15) NOT NULL,
    cl_usernum    VARCHAR2(10) NOT NULL,
    cl_limit    VARCHAR2(10) NOT NULL,
    cl_id    VARCHAR2(10) NOT NULL,
    emp_id    VARCHAR2(10) NOT NULL,
    pool_id    VARCHAR2(10) NOT NULL
);

COMMENT ON COLUMN class.cl_name IS '강의명';

COMMENT ON COLUMN class.cl_date IS '강의날짜';

COMMENT ON COLUMN class.cl_usernum IS '수강인원';

COMMENT ON COLUMN class.cl_limit IS '제한인원';

COMMENT ON COLUMN class.cl_id IS '강의코드';

COMMENT ON COLUMN class.emp_id IS '강사코드';

COMMENT ON COLUMN class.pool_id IS '수영장코드';

COMMENT ON TABLE class IS '개설강좌';

ALTER TABLE class
 ADD CONSTRAINT class_PK PRIMARY KEY (cl_id)
 USING INDEX class_PK;

DROP INDEX class_PK;

CREATE UNIQUE INDEX class_PK ON class
( cl_id );


DROP TABLE emp;

CREATE TABLE emp
(
    emp_id    VARCHAR2(10) NOT NULL,
    emp_name    VARCHAR2(10) NOT NULL,
    emp_career    VARCHAR2(30)
);

COMMENT ON COLUMN emp.emp_id IS '강사코드';

COMMENT ON COLUMN emp.emp_name IS '강사명';

COMMENT ON COLUMN emp.emp_career IS '경력';

COMMENT ON TABLE emp IS '강사';

ALTER TABLE emp
 ADD CONSTRAINT emp_PK PRIMARY KEY (emp_id)
 USING INDEX emp_PK;

DROP INDEX emp_PK;

CREATE UNIQUE INDEX emp_PK ON emp
( emp_id );

DROP TABLE member;

CREATE TABLE member
(
    mem_date    DATE NOT NULL,
    mem_name    VARCHAR2(10) NOT NULL,
    mem_id    VARCHAR2(10) NOT NULL,
    mem_add    VARCHAR2(20),
    mem_phone    VARCHAR2(15) NOT NULL,
    mem_rrn    VARCHAR2(15) NOT NULL
);

COMMENT ON COLUMN member.mem_date IS '가입날짜';

COMMENT ON COLUMN member.mem_name IS '회원명';

COMMENT ON COLUMN member.mem_id IS '회원코드';

COMMENT ON COLUMN member.mem_add IS '주소';

COMMENT ON COLUMN member.mem_phone IS '연락처';

COMMENT ON COLUMN member.mem_rrn IS '주민등록번호';

COMMENT ON TABLE member IS '회원';

ALTER TABLE member
 ADD CONSTRAINT member_PK PRIMARY KEY (mem_id)
 USING INDEX member_PK;

DROP INDEX member_PK;

CREATE UNIQUE INDEX member_PK ON member
( mem_id );


DROP TABLE member_3;

CREATE TABLE member_3
(
    mem_date    DATE NOT NULL,
    mem_name    VARCHAR2(10) NOT NULL,
    mem_id    VARCHAR2(10) NOT NULL,
    mem_add    VARCHAR2(20),
    mem_phone    VARCHAR2(15) NOT NULL,
    mem_rrn    VARCHAR2(15) NOT NULL
);

COMMENT ON COLUMN member_3.mem_date IS '가입날짜';

COMMENT ON COLUMN member_3.mem_name IS '회원명';

COMMENT ON COLUMN member_3.mem_id IS '회원코드';

COMMENT ON COLUMN member_3.mem_add IS '주소';

COMMENT ON COLUMN member_3.mem_phone IS '연락처';

COMMENT ON COLUMN member_3.mem_rrn IS '주민등록번호';

COMMENT ON TABLE member_3 IS '회원_1';

ALTER TABLE member_3
 ADD CONSTRAINT member_3_PK PRIMARY KEY (mem_id)
 USING INDEX member_3_PK;

DROP INDEX member_3_PK;

CREATE UNIQUE INDEX member_3_PK ON member_3
( mem_id );

DROP TABLE member_3_1;

CREATE TABLE member_3_1
(
    mem_date    DATE NOT NULL,
    mem_name    VARCHAR2(10) NOT NULL,
    mem_id    VARCHAR2(10) NOT NULL,
    mem_add    VARCHAR2(20),
    mem_phone    VARCHAR2(15) NOT NULL,
    mem_rrn    VARCHAR2(15) NOT NULL
);

COMMENT ON COLUMN member_3_1.mem_date IS '가입날짜';

COMMENT ON COLUMN member_3_1.mem_name IS '회원명';

COMMENT ON COLUMN member_3_1.mem_id IS '회원코드';

COMMENT ON COLUMN member_3_1.mem_add IS '주소';

COMMENT ON COLUMN member_3_1.mem_phone IS '연락처';

COMMENT ON COLUMN member_3_1.mem_rrn IS '주민등록번호';

COMMENT ON TABLE member_3_1 IS '회원_1_1';

ALTER TABLE member_3_1
 ADD CONSTRAINT member_3_1_PK PRIMARY KEY (mem_id)
 USING INDEX member_3_1_PK;

DROP INDEX member_3_1_PK;

CREATE UNIQUE INDEX member_3_1_PK ON member_3_1
( mem_id );

DROP TABLE myclass;

CREATE TABLE myclass
(
    mycl_id    VARCHAR2(10) NOT NULL,
    cl_id    VARCHAR2(10) NOT NULL,
    mem_id    VARCHAR2(10) NOT NULL
);

COMMENT ON COLUMN myclass.mycl_id IS '수강강습id';

COMMENT ON COLUMN myclass.cl_id IS '강의코드';

COMMENT ON COLUMN myclass.mem_id IS '회원코드';

COMMENT ON TABLE myclass IS '수강강습';

ALTER TABLE myclass
 ADD CONSTRAINT myclass_PK PRIMARY KEY (mycl_id)
 USING INDEX myclass_PK;

DROP INDEX myclass_PK;

CREATE UNIQUE INDEX myclass_PK ON myclass
( mycl_id );


DROP TABLE pool;

CREATE TABLE pool
(
    pool_id    VARCHAR2(10) NOT NULL,
    pool_div    VARCHAR2(10) NOT NULL
);

COMMENT ON COLUMN pool.pool_id IS '수영장코드';

COMMENT ON COLUMN pool.pool_div IS '수영장구분';

COMMENT ON TABLE pool IS '수영장';

ALTER TABLE pool
 ADD CONSTRAINT pool_PK PRIMARY KEY (pool_id)
 USING INDEX pool_PK;

DROP INDEX pool_PK;

CREATE UNIQUE INDEX pool_PK ON pool
( pool_id );


