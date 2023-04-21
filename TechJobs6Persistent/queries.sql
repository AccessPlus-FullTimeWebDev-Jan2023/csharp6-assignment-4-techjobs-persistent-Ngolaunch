-- Capture your answer here for each "Test It With SQL" section of this assignment
    -- write each as comments


--Part 1: List the columns and their data types in the Jobs table.
--Id int(11)
--Employer longtext
--Employerid int (11)

--Part 2: Write a query to list the names of the employers in St. Louis City.
-- SEL Name
--from Employers
-- where location = "St. Louis City"


--Part 3: Write a query to return a list of the names and descriptions of all skills that are attached to jobs in alphabetical order.

--select SkillName 
--from skills
--inner join jobskills on skills.id = jobskills.skillsid
--where 
--jobskills.jobsid IS NOT NULL
--order by skillName ASC

    --If a skill does not have a job listed, it should not be included in the results of this query.
    