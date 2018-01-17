namespace VRTK.Examples
{
    using UnityEngine;

    public class UI_Button : VRTK_InteractableObject
    {
        float spinSpeed = 0f;
        Transform rotator;

        public override void StartUsing(VRTK_InteractUse usingObject)
        {
            base.StartUsing(usingObject);
			Debug.Log("Hilight btn");
           // spinSpeed = 360f;
        }

        public override void StopUsing(VRTK_InteractUse usingObject)
        {
            base.StopUsing(usingObject);
			Debug.Log("DONE btn  action ");
           // spinSpeed = 0f;
        }

        protected void Start()
        {
          //  rotator = transform.Find("Capsule");
        }

        // protected override void Update()
        // {
        //     base.Update();
        //     rotator.transform.Rotate(new Vector3(spinSpeed * Time.deltaTime, 0f, 0f));
        // }
    }
}