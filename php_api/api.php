<?php
header("Content-Type: application/json");

$host = 'localhost';
$db = 'emp_mgt';
$user = 'root';
$pass = '';
$charset = 'utf8mb4';

$dsn = "mysql:host=$host;dbname=$db;charset=$charset";
$options = [
    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
    PDO::ATTR_EMULATE_PREPARES => false,
];

$pdo = new PDO($dsn, $user, $pass, $options);

// get
if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $stmt = $pdo->query("SELECT e.emp_id, e.first_name, e.last_name, e.contact_num, e.email, d.dept_name, d.dept_location FROM employee e JOIN department d ON e.dept_id = d.dept_id ORDER BY e.emp_id ASC");
    $users = $stmt->fetchAll();
    echo json_encode($users);

// post
} elseif ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $input = json_decode(file_get_contents('php://input'), true);
    $sql = "INSERT INTO employee (first_name, last_name, contact_num, email, dept_id) VALUES (?, ?, ?, ?, ?)";
    $stmt = $pdo->prepare($sql);
    $stmt->execute([$input['first_name'], $input['last_name'], $input['contact_num'], $input['email'], $input['dept_id']]);
    echo json_encode(['message' => 'User added successfully']);
}
?>