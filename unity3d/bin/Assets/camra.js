#pragma strict

var target : Transform;
var distance = 10.0;

var xSpeed = 250.0;
var ySpeed = 120.0;

var yMinLimit = -20;
var yMaxLimit = 80;

// Aumentado esto:
var maxDist : float = 200;
var minDist : float = 30;
var zoomSpeed : float = 5;
// hasta aca

private var x = 0.0;
private var y = 0.0;

@script AddComponentMenu("Camera-Control/Mouse Orbit")

function Start () {
    var angles = transform.eulerAngles;
    x = angles.y;
    y = angles.x;

    // Make the rigid body not change rotation
    if (rigidbody)
        rigidbody.freezeRotation = true;
}

function LateUpdate () {
    if (target && Input.GetMouseButton(1))  {
        x += Input.GetAxis("Mouse X") * xSpeed * 0.02;
        y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02;

        y = ClampAngle(y, yMinLimit, yMaxLimit);
}
        var rotation = Quaternion.Euler(y, x, 0);
        var position = rotation * Vector3(0.0, 0.0, -distance) + target.position;

        transform.rotation = rotation;
        transform.position = position;
    
    // Aumentado esto:
      if (Input.GetAxis("Mouse ScrollWheel") < 0 && distance < maxDist){           
           distance += zoomSpeed;                             
           transform.Translate(Vector3.forward * -zoomSpeed); 
    }
    // hasta aca
    // Aumentado esto:
     if (Input.GetAxis("Mouse ScrollWheel") > 0 && distance > minDist){     
               distance -= zoomSpeed;                             
               transform.Translate(Vector3.forward * zoomSpeed); 
}
// hasta aca
}

static function ClampAngle (angle : float, min : float, max : float) {
    if (angle < -360)
        angle += 360;
    if (angle > 360)
        angle -= 360;
    return Mathf.Clamp (angle, min, max);
}