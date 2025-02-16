CREATE TABLE REGIONS
    ( region_id      int 
       CONSTRAINT  region_id_nn NOT NULL, 
	   region_name    VARCHAR(25) 
    );


	 CREATE TABLE COUNTRIES 
    ( COUNTRY_ID      CHAR(2) 
       CONSTRAINT  COUNTRY_ID_NN NOT NULL 
    , COUNTRY_NAME    VARCHAR(40) 
    , REGION_ID       int 
    , CONSTRAINT     COUNTRY_C_ID_PK 
                     PRIMARY KEY (COUNTRY_ID) 
    ) 


	 CREATE TABLE LOCATIONS
    ( LOCATION_ID    int not null
    , STREET_ADDRESS VARCHAR(40)
    , POSTAL_CODE    VARCHAR(12)
    , CITY       VARCHAR(30)
        CONSTRAINT     LOC_CITY_NN  NOT NULL
    , STATE_PROVINCE VARCHAR(25)
    , COUNTRY_ID     CHAR(2)
    ) ;
    

INSERT INTO regions VALUES( 1, 'Europe');
INSERT INTO regions VALUES( 2, 'Americas');
INSERT INTO regions VALUES( 3, 'Asia');
INSERT INTO regions VALUES( 4, 'Middle East and Africa');   
INSERT INTO regions VALUES( 6, 'Sub-Saharan Africa');   

SELECT * FROM regions

INSERT INTO countries VALUES( 'IT', 'Italy', 1);
INSERT INTO countries VALUES( 'JP', 'Japan', 3);
INSERT INTO countries VALUES( 'US', 'United States of America', 2);
INSERT INTO countries VALUES( 'CA', 'Canada', 2);
INSERT INTO countries VALUES( 'CN', 'China', 3);
INSERT INTO countries VALUES( 'IN', 'India', 3);
INSERT INTO countries VALUES( 'AU', 'Australia', 3);
INSERT INTO countries VALUES( 'ZW', 'Zimbabwe',4);


INSERT INTO countries VALUES( 'SG', 'Singapore', 3);
INSERT INTO countries VALUES( 'UK', 'United Kingdom', 1);
INSERT INTO countries VALUES( 'FR', 'France', 1);
INSERT INTO countries VALUES( 'DE', 'Germany', 1);
INSERT INTO countries VALUES( 'ZM', 'Zambia', 4);
INSERT INTO countries VALUES( 'EG', 'Egypt', 4);
INSERT INTO countries VALUES( 'BR', 'Brazil', 2);
INSERT INTO countries VALUES( 'CH', 'Switzerland', 1);


INSERT INTO countries VALUES( 'NL', 'Netherlands', 1);
INSERT INTO countries VALUES( 'MX', 'Mexico', 2);
INSERT INTO countries VALUES( 'KW', 'Kuwait', 4);
INSERT INTO countries VALUES( 'IL', 'Israel', 4);
INSERT INTO countries VALUES( 'DK', 'Denmark', 1);
INSERT INTO countries VALUES( 'HK', 'HongKong', 3);
INSERT INTO countries VALUES( 'NG', 'Nigeria', 4);
INSERT INTO countries VALUES( 'AR', 'Argentina', 2);
INSERT INTO countries VALUES( 'BE', 'Belgium', 1);

select * FROM COUNTRIES

INSERT INTO locations VALUES( 1000, '1297 Via Cola di Rie', '00989', 'Roma', NULL, 'IT');
INSERT INTO locations VALUES( 1100, '93091 Calle della Testa', '10934', 'Venice', NULL, 'IT');
INSERT INTO locations VALUES( 1200, '2017 Shinjuku-ku', '1689', 'Tokyo', 'Tokyo Prefecture', 'JP');
INSERT INTO locations VALUES( 1300, '9450 Kamiya-cho', '6823', 'Hiroshima', NULL, 'JP');
INSERT INTO locations VALUES( 1400, '2014 Jabberwocky Rd', '26192', 'Southlake', 'Texas', 'US');
INSERT INTO locations VALUES( 1500, '2011 Interiors Blvd', '99236', 'South San Francisco', 'California', 'US');
INSERT INTO locations VALUES( 1600, '2007 Zagora St', '50090', 'South Brunswick', 'New Jersey', 'US');
INSERT INTO locations VALUES( 1700, '2004 Charade Rd', '98199', 'Seattle', 'Washington', 'US');
INSERT INTO locations VALUES( 1800, '147 Spadina Ave', 'M5V 2L7', 'Toronto', 'Ontario', 'CA');
INSERT INTO locations VALUES( 1900, '6092 Boxwood St', 'YSW 9T2', 'Whitehorse', 'Yukon', 'CA');
INSERT INTO locations VALUES( 7712, 'Row House No. 141', '400639', 'Maharashtra', 'India', 'IN');



select COUNTRY_ID FROM locations

--Excercise : --Display Your Home Addres With Region Name and Contry
SELECT C.COUNTRY_NAME,R.REGION_NAME,L.STREET_ADDRESS,L.STATE_PROVINCE,L.CITY,L.POSTAL_CODE
FROM LOCATIONS L JOIN  COUNTRIES C
ON L.COUNTRY_ID=C.COUNTRY_ID
JOIN REGIONS R
ON C.REGION_ID=R.REGION_ID
WHERE LOCATION_ID=7712

--Excerise--Display Region where no COUNTRY

SELECT R.region_name,C.COUNTRY_NAME
FROM REGIONS R LEFT OUTER JOIN COUNTRIES C
ON R.region_id=C.REGION_ID
WHERE C.COUNTRY_NAME is null

--Excerise--Display Country where location is null

SELECT C.COUNTRY_NAME,L.STREET_ADDRESS,L.CITY,L.POSTAL_CODE,L.LOCATION_ID
FROM COUNTRIES C LEFT OUTER JOIN  LOCATIONS L
ON C.COUNTRY_ID=L.COUNTRY_ID
WHERE L.LOCATION_ID is null


--Excerise--Display Country wise location
SELECT C.COUNTRY_NAME,COUNT(*) as [count]
FROM COUNTRIES C LEFT OUTER JOIN  LOCATIONS L
ON C.COUNTRY_ID=L.COUNTRY_ID
group by C.COUNTRY_NAME


--Country location grater than 3
SELECT C.COUNTRY_NAME,COUNT(*) as [count]
FROM COUNTRIES C LEFT OUTER JOIN  LOCATIONS L
ON C.COUNTRY_ID=L.COUNTRY_ID
group by C.COUNTRY_NAME
Having COUNT(*) >3


SELECT * FROM REGIONS
SELECT * FROM COUNTRIES