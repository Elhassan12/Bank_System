/*SQL QUERY STATMENT (A)*/
select [BRANCH_NUMBER],[ADDRESS] from [dbo].[TB_BRANCH] where  NOT Exists (select *  from [dbo].[TB_CUSTOMER] where [dbo].[TB_BRANCH].[BRANCH_NUMBER]=[dbo].[TB_CUSTOMER].[BRANCH_NUMBER] )

/*SQL QUERY STATMENT (B)*/
select [BRANCH_NUMBER],[ADDRESS] from [dbo].[TB_BRANCH] where  NOT Exists (select *  from [dbo].[TB_EMPLOYEE] where [dbo].[TB_BRANCH].[BRANCH_NUMBER]=[dbo].[TB_EMPLOYEE].[BRANCH_NUMBER] )


/*SQL QUERY STATMENT (C)*/
select top 1 c.SSN_EMPLOYEE,c.[NAME],c.[PHONE],count(*) as num_of_loans from [dbo].[TB_EMPLOYEE]  c join [dbo].[TB_LOAN] l on c.SSN_EMPLOYEE= l.SSN_EMPLOYEE Group by c.SSN_EMPLOYEE ,c.NAME,c.PHONE order by count(*) desc


/*SQL QUERY STATMENT (D)*/
select top 1 c.SSN,c.[NAME],c.[PHONE],count(*) as num_of_loans from  [dbo].[TB_CUSTOMER] c join [dbo].[TB_ACCOUNT] l on c.SSN= l.SSN join [dbo].[TB_LOAN] n on n.ACCOUNT_NUMBER=l.ACCOUNT_NUMBER Group by c.SSN ,c.NAME,c.PHONE order by count(*) desc


/*SQL QUERY STATMENT (E)*/
select [SSN],[NAME] from[dbo].[TB_CUSTOMER]  where  NOT Exists (select *  from [dbo].[TB_ACCOUNT],[dbo].[TB_LOAN] where [dbo].[TB_CUSTOMER].[SSN]=[dbo].[TB_ACCOUNT].[SSN] AND [dbo].[TB_ACCOUNT].[ACCOUNT_NUMBER]=[dbo].[TB_LOAN].[ACCOUNT_NUMBER])


/*SQL QUERY STATMENT (F)*/  
select [dbo].[TB_CUSTOMER].NAME,[dbo].[TB_CUSTOMER].SSN,[dbo].[TB_CUSTOMER].PHONE,[dbo].[TB_CUSTOMER].ADDRESS,[dbo].[TB_CUSTOMER].BRANCH_NUMBER,count([dbo].[TB_LOAN].ACCOUNT_NUMBER) as no_of_deals, [dbo].[TB_LOAN].[SSN_EMPLOYEE] from [dbo].[TB_LOAN] ,[dbo].[TB_CUSTOMER],[dbo].[TB_ACCOUNT] where [dbo].[TB_LOAN].ACCOUNT_NUMBER=[dbo].[TB_ACCOUNT].ACCOUNT_NUMBER and [dbo].[TB_CUSTOMER].SSN=[dbo].[TB_ACCOUNT].SSN group by [dbo].[TB_CUSTOMER].NAME,[dbo].[TB_CUSTOMER].SSN,[dbo].[TB_CUSTOMER].PHONE,[dbo].[TB_CUSTOMER].ADDRESS,[dbo].[TB_CUSTOMER].BRANCH_NUMBER,[dbo].[TB_LOAN].ACCOUNT_NUMBER,[dbo].[TB_LOAN].[SSN_EMPLOYEE],[dbo].[TB_CUSTOMER].NAME 
                    
                    
                                       
       
                                       
     



 







		
SELECT MAX(SSN_EMPLOYEE) FROM ( SELECT count(SSN_EMPLOYEE) AS LOAN FROM TB_LOAN GROUP BY TB_LOAN.SSN_EMPLOYEE)
		 
		 
		 




SELECT COUNT([SSN_EMPLOYEE]), FROM [dbo].[TB_LOAN]
GROUP BY [SSN_EMPLOYEE]
ORDER BY [SSN_EMPLOYEE] ASC

  





