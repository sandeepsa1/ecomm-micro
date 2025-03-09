# User Service (Microservices with Docker & MySQL)

This is a **User Service** built with **FastAPI** and **MySQL**, containerized using **Docker** and managed with **Docker Compose**.

## 1️⃣ Setup & Run Locally

### Prerequisites
- Python 3.12  
- Docker & Docker Compose  
- MySQL  

### Steps to Run Locally
1. Clone the repository:  
   ```sh
   git clone <repo-url>
   cd user-service
Install dependencies:
sh
Copy
Edit
pip install -r requirements.txt
Set up the database connection in .env or config.py:
env
Copy
Edit
DATABASE_URL=mysql+pymysql://root:password@localhost:3307/userdb
Run the service:
sh
Copy
Edit
uvicorn main:app --reload
Access API at http://localhost:8000/docs.
2️⃣ Docker Setup
Steps to Run with Docker
Build & Run Containers
sh
Copy
Edit
docker-compose up --build -d
Check Running Containers
sh
Copy
Edit
docker ps
Stop Containers
sh
Copy
Edit
docker-compose down
Service Ports
Service	Host Port	Container Port
User API	8000	8000
MySQL	3307	3306
Note: Inside Docker, the User Service connects to MySQL using mysql:3306, but from outside, use localhost:3307.

3️⃣ API Endpoints
Method	Endpoint	Description
GET	/users	Fetch all users
POST	/users	Create a new user
GET	/users/{id}	Get user by ID
