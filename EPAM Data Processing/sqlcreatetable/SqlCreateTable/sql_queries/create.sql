CREATE TABLE Employees (
    Id INTEGER IDENTITY (1,1),
    FirstName VARCHAR(255) NOT NULL,
    SecondName VARCHAR(255) NOT NULL,
    CONSTRAINT pk_Employees PRIMARY KEY (Id)
);

CREATE TABLE ProjectStatus (
    Id INTEGER IDENTITY (1,1),
    Name VARCHAR(255) NOT NULL UNIQUE,
    CONSTRAINT pk_ProjectStatus PRIMARY KEY (Id)
);

CREATE TABLE Projects (
    Id INTEGER IDENTITY (1,1),
    Name VARCHAR(255) NOT NULL UNIQUE,
    CreationDate DATE NOT NULL,
    Status INTEGER NOT NULL,
    ClosureDate DATE,
    CONSTRAINT pk_Projects PRIMARY KEY (Id),
    CONSTRAINT fk1_Projects
    FOREIGN KEY (Status) REFERENCES ProjectStatus(Id)
);

CREATE TABLE Positions (
    Id INTEGER IDENTITY (1,1),
    Name VARCHAR(255) NOT NULL UNIQUE,
    CONSTRAINT pk_Positions PRIMARY KEY (Id)
);

CREATE TABLE EmployeesPositions (
    Id INTEGER IDENTITY (1,1),
    Employee INTEGER NOT NULL,
    Project INTEGER NOT NULL,
    Position INTEGER NOT NULL,
    CONSTRAINT pk_EmployeesPositions PRIMARY KEY (Id),
    CONSTRAINT fk1_EmployeesPositions
    FOREIGN KEY (Employee) REFERENCES Employees(Id),
    CONSTRAINT fk2_EmployeesPositions
    FOREIGN KEY (Project) REFERENCES Projects(Id),
    CONSTRAINT fk3_EmployeesPositions
    FOREIGN KEY (Position) REFERENCES Positions(Id)
);

CREATE TABLE Tasks (
    Id INTEGER IDENTITY (1,1),
    Project INTEGER NOT NULL,
    Employee INTEGER NOT NULL,
    Description VARCHAR(255) NOT NULL,
    Deadline DATE NOT NULL,
    CONSTRAINT pk_Tasks PRIMARY KEY (Id),
    CONSTRAINT fk1_Tasks
    FOREIGN KEY (Project) REFERENCES Projects(Id),
    CONSTRAINT fk2_Tasks
    FOREIGN KEY (Employee) REFERENCES Employees(Id)
);

CREATE TABLE TaskStatus (
    Id INTEGER IDENTITY (1,1),
    Name VARCHAR(255) NOT NULL UNIQUE,
    CONSTRAINT pk_TaskStatus PRIMARY KEY (Id)
);

CREATE TABLE TaskStatusChanges (
    Id INTEGER IDENTITY (1,1),
    Task INTEGER NOT NULL,
    Status INTEGER NOT NULL,
    Employee INTEGER NOT NULL,
    ChangeStatusDate DATE NOT NULL,
    CONSTRAINT pk_TaskStatusChanges PRIMARY KEY (Id),
    CONSTRAINT fk1_TaskStatusChanges
    FOREIGN KEY (Task) REFERENCES Tasks(Id),
    CONSTRAINT fk2_TaskStatusChanges
    FOREIGN KEY (Status) REFERENCES TaskStatus(Id),
    CONSTRAINT fk3_TaskStatusChanges
    FOREIGN KEY (Employee) REFERENCES Employees(Id)
);
