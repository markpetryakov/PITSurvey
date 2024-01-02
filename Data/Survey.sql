CREATE DATABASE Survey;

USE Survey;

CREATE TABLE SurveyAnswers (
    SurveyResponseID INT AUTO_INCREMENT PRIMARY KEY,
    DateTime TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    SurveyorInitials VARCHAR(50),
    ContactNumber VARCHAR(50),
    SurveyorAge VARCHAR(50),
	SurveyorYearBirth INT
    );

CREATE TABLE Sections3_5 (
    SurveyResponseID INT,
    FirstTimeHomeless VARCHAR(50),
    TimeHomeless VARCHAR(50),
    StayedInShelter VARCHAR(50),
    NotStayedInShelterReason VARCHAR(50),
    
    FOREIGN KEY (SurveyResponseID) REFERENCES SurveyAnswers(SurveyResponseID)
);

CREATE TABLE Sections6_10 (
    SurveyResponseID INT,
    ImmigrationStatus VARCHAR(50),
    TimeInCanada VARCHAR(50),
    DateInCanada VARCHAR(50),
    CanadianCitizen VARCHAR(50),
    NonCitizenStatus VARCHAR(50),
    LengthOfTimeInOttawa VARCHAR(50),
    LivedBeforeOttawa VARCHAR(50),
    ReasonForComingToOttawa VARCHAR(50),
	IndigenousCommunity VARCHAR(50),
    RacialIdentity VARCHAR(50),
    ServedMilitary VARCHAR(50),
    FosterCare VARCHAR(50),
    HomelessAfterFosterCare VARCHAR(50),

    FOREIGN KEY (SurveyResponseID) REFERENCES SurveyAnswers(SurveyResponseID)
);

CREATE TABLE Sections11_13 (
    SurveyResponseID INT,
    IllnessOrMedicalCondition VARCHAR(50),
    PhysicalLimitation VARCHAR(50),
    LearningOrCognitiveLimitations VARCHAR(50),
    MentalHealthIssue VARCHAR(50),
    SubstanceUseIssue VARCHAR(50),
    BrainInjuryAfterBirth VARCHAR(50),
    Gender VARCHAR(50),
    SexualOrientation VARCHAR(50),
    
    FOREIGN KEY (SurveyResponseID) REFERENCES SurveyAnswers (SurveyResponseID)
);

CREATE TABLE Section14 (
    SurveyResponseID INT,
    HousingAndFinancialIssues VARCHAR(50),
    InterpersonalAndFamilyIssues VARCHAR(50),
    HealthOrCorrections VARCHAR(50),
    OtherHousingLossReason VARCHAR(50),
    CovidRelatedLoss VARCHAR(50),
    HousingLossHappenedAgo VARCHAR(50),
    
    FOREIGN KEY (SurveyResponseID) REFERENCES SurveyAnswers(SurveyResponseID)
);

CREATE TABLE Sections15_19 (
    SurveyResponseID INT,
    SourcesOfIncome VARCHAR(50),
    LevelOfEducation VARCHAR(50),
    WantToGetIntoPermanentHousing VARCHAR(50),
    ChallengesToFindHousing VARCHAR(50),
    SupportToHelpHousing VARCHAR(50),
    FOREIGN KEY (SurveyResponseID) REFERENCES SurveyAnswers(SurveyResponseID)
);

CREATE TABLE FamilyMembers (
    SurveyResponseID INT,
    Relationship VARCHAR(50),
    Gender VARCHAR(50),
    Age INT,
    FOREIGN KEY (SurveyResponseID) REFERENCES SurveyAnswers(SurveyResponseID)
);
