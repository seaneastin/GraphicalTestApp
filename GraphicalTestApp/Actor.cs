﻿using System;
using System.Collections.Generic;

namespace GraphicalTestApp
{
    delegate void StartEvent();
    delegate void UpdateEvent(float deltaTime);
    delegate void DrawEvent();

    class Actor
    {
        public StartEvent OnStart;
        public UpdateEvent OnUpdate;
        public DrawEvent OnDraw;

        public bool Started { get; private set; } = false;

        public Actor Parent { get; private set; } = null;
        private List<Actor> _children = new List<Actor>();
        private List<Actor> _additions = new List<Actor>();
        private List<Actor> _removals = new List<Actor>();


        private Matrix3 _localTransform = new Matrix3();
        private Matrix3 _globalTransform = new Matrix3();
        
        public float X
        {
            get { return _localTransform.m13; }
            set { _localTransform.SetTranslation(value, Y, 1);
                UpdateTransform();
            }
        }
        public float XAbsolute
        {
            get { return _globalTransform.m13; }
        }
        public float Y
        {
            get { return _localTransform.m23; }
            set
            {
                _localTransform.SetTranslation(X, value, 1);
                UpdateTransform();
            }
        }
        public float YAbsolute
        {
            get { return _globalTransform.m23; }
        }

        public float GetRotation()
        {
            return (float)Math.Atan2(_globalTransform.m21, _globalTransform.m11);
        }

        public void Rotate(float radians)
        {
            _localTransform.RotateZ(radians);
            UpdateTransform();
        }

        public float GetScale()
        {
            return 1;
        }


        public void AddChild(Actor child)
        {
            //Make sure the child doesn't already have a parent
            if (child.Parent != null)
            {
                return;
                
            }
            //Assign this Entity as the child's parent
            child.Parent = this;
            //Add child to collection

            _additions.Add(child);
        }

        public void RemoveChild(Actor child)
        {
            bool isMyChild = _children.Contains(child);
            if (isMyChild)
            {
                child.Parent = null;
                child._localTransform = child._globalTransform;
                _removals.Add(child);
            }
        }

        public void UpdateTransform()
        {
            if (Parent != null)
            {
                _globalTransform = Parent._globalTransform * _localTransform;
            }
            else
            {
                _globalTransform = _localTransform;
            }

            foreach (Actor child in _children)
            {
                child.UpdateTransform();
            }
        }

        //Call the OnStart events of the Actor and its children
        public virtual void Start()
        {
            //Call this Actor's OnStart events
            OnStart?.Invoke();

            //Start all of this Actor's children
            foreach (Actor child in _children)
            {
                child.Start();
            }

            //Flag this Actor as having already started
            Started = true;
        }

        //Call the OnUpdate events of the Actor and its children
        public virtual void Update(float deltaTime)
        {
            //Update this Actor and its children's transforms
            UpdateTransform();

            //Call this Actor's OnUpdate events
            OnUpdate?.Invoke(deltaTime);

            //Add all the Actors readied for addition
            foreach (Actor a in _additions)
            {
                //Add a to _children
                _children.Add(a);
            }

            //remove all the Actors readied for removal

            _additions.Clear();


            foreach (Actor a in _removals)
            {
                //remove a from _children
                _children.Remove(a);
            }

            //reset the removal list

            _removals.Clear();

            

            //Update all of this Actor's children
            foreach (Actor child in _children)
            {
                child.Update(deltaTime);
            }
        }

        //Call the OnDraw events of the Actor and its children
        public virtual void Draw()
        {
            //Call this Actor's OnDraw events
            OnDraw?.Invoke();

            //Update all of this Actor's children
            foreach (Actor child in _children)
            {
                child.Draw();
            }
        }

        public float Getm11
        {
            get
            {
                return _globalTransform.m11;
            }
        }

        public float Getm12
        {
            get
            {
                return _globalTransform.m12;
            }
        }

    }
}
