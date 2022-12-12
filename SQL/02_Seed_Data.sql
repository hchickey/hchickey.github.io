USE [MyProfile];
GO


set identity_insert [Skill] on
insert into [Skill] ([Id], [Title], [Level], [Keyword]) 
values (1, 'JavaScript', 'Proficient', 'developer'), (2, 'React', 'Proficient', 'framework'), (3, 'C#', 'Proficient', 'backend developer'), (4, '.NET', 'Proficient', 'backend'), (5, 'CSS', 'Advanced', 'styling'), (6, 'HTML', 'Advanced', 'web browser');
set identity_insert [Skill] off

set identity_insert [Interest] on
insert into [Interest] ([Id], [Hobby])
values (1, 'Web Development'), (2, 'Videography'), (3, 'Video Editing'), (4, 'Kayaking'), (5, 'Hiking'), (6, 'Dancing'), (7, 'Traveling'), (8, 'Playing badminton');
set identity_insert [Interest] off

set identity_insert [Basic] on
insert into Basic (Id, Name, ImageUrl, Email, Phone, Summary) values (1, 'Haley Hickey', NULL, 'hchickey96@gmail.com', '479-597-9225', 'A little about me. Before beginning my journey at Nashville Software School to become a Full Stack Web Developer, I was working as an experienced Church and Community Outreach Coordinator for a non-profit called, Raise the Roof Academy. I love helping others whether it is through missionary work or creating. Working in the non-profit field gave me the resources to help people and help our community. It allowed me to solve problems using logic while working with volunteers and working in a team environment. When a friend introduced me to software development, I realized that the tech field would allow me to continue my love for helping others but in a more creative way.');
set identity_insert [Basic] off

set identity_insert [Education] on
insert into Education (Id, School, Area, StudyType, StartDate, EndDate) values (1, 'Nashville Software School', 'FullStack Web Development', 'Tech Bootcamp', '05/16/2022', '11/04/2022');
insert into Education (Id, School, Area, StudyType, StartDate, EndDate) values (2, 'Lipscomb University', 'Strategic Communications', 'Bachelor of Arts', '08/15/2015', '05/04/2019');
set identity_insert [Education] off

set identity_insert [Profile] on
insert into Profile (Id, Network, UserName, Url) values (1, 'LinkedIn', 'hchickey96', 'https://www.linkedin.com/in/hchickey96/');
insert into Profile (Id, Network, UserName, Url) values (2, 'Github', 'hchickey', 'https://github.com/hchickey');
insert into Profile (Id, Network, UserName, Url) values (3, 'Instagram', 'haleyyred', 'https://www.instagram.com/haleyyred/');
set identity_insert [Profile] off

set identity_insert [UserProfile] on
insert into UserProfile (Id, FirebaseUserId, DisplayName, FirstName, LastName, Email) values (1, 'Ilaemt6alvM0BldpMI76IfMpkx93', 'haleyred', 'Haley', 'Hickey', 'hchickey96@gmail.com');
set identity_insert [UserProfile] off

set identity_insert [Volunteer] on
insert into Volunteer (Id, Organization, Sumary) values (1, 'CFMT Tornado Response', 'On March 2, 2020 a tornado hit Middle Tennessee that resulted in 25 deaths and a path of desctruction that went through Nashville, Mount Juliet, Lebanon and Gordonsville, TN. I volunteered to help clean up debri in East Nashville area where a lot of homes were destroyed.');
insert into Volunteer (Id, Organization, Sumary) values (2, 'Owl Hill Nature Sanctuary', 'I graduated from Lipscomb University in 2019 and every year they have one dedicated day of serving the Nashville community. They call it Service Day, where classes are canceled and schedules are cleared so all of Lipscomb can give back to Nashville.');
insert into Volunteer (Id, Organization, Sumary) values (2, 'Room in the Inn', 'Lipscomb also had a program where they partnered with Room in the Inn, which is a nonprofit that provides programs for the homeless that emphasize human development and recovery through education, self-help and work. I would volunteer to help cook dinner for them and set up a place for them to stay in our on campus gym.');
set identity_insert [Volunteer] off

set identity_insert [Work] on
insert into Work (Id, Company, Position, Website, StartDate, EndDate, Summary) values (1, 'Nashville Software School', 'FullStack Web Developer Apprenticeship', 'https://nashvillesoftwareschool.com/', '05/16/2022', '11/04/2022', 'A six month full-stack web developer apprenticeship that focuses
on instructing developers through a hands-on and intensive
training. Training includes an introduction to real-world
methodologies, utilizing agile with scrum implementation.
- Build single page applications using HTML, CSS, JavaScript,
and React
- Utilize C#, .NET and SQL to implement server side
applications
- Utilize third party APIs to include data in web applications
- Source code version control with Git / Github');
insert into Work (Id, Company, Position, Website, StartDate, EndDate, Summary) values (2, 'Kestner Chiropractic', 'Chiropractic Therapy Assistant', 'https://drkestner.com/', '12/04/2020', '05/06/2022', '- Perform administrative functions for a chiropractic office, delivering outpatient medical services, field phone inquiries, schedule patient appointments, manage calendars, verify patient insurance, and collect payments for treatment.
- Communicate with diverse patient populations, greet patients upon arrival, gather medical history and documentation, and verify physician referrals
- Prepare treatment rooms for patient appointments, including cleaning and sanitizing surfaces and equipment in compliance with health and safety protocols'); 
insert into Work (Id, Company, Position, Website, StartDate, EndDate, Summary) values (3, 'Freelance Work', 'Videographer/Editor', 'https://hchickey.wixsite.com/hchickeyportfolio/videos', '2020', '2022', '- Works collaboratively with Nashville musicians and creatives to
support their goals
- Shoot and edit compelling, impactful stories that are clear and
easy to understand
- Develops videos for marketing and social media needs');
insert into Work (Id, Company, Position, Website, StartDate, EndDate, Summary) values (4, 'Raise the Roof Academy', 'Church and Community Relations Coordinator', 'https://www.raisetheroofacademy.org/', '09/16/2019', '04/22/2020', '- Identified and maintained strategic community alignments,
leveraging partnerships that created program awareness and
led to increased child sponsorships
- Coordinated fundraising events
- Led presentations to promote RTRA mission');
set identity_insert [Work] off