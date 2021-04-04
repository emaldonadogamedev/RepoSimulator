using System;
using System.Collections.Generic;
using UnityEngine;

using Random = UnityEngine.Random;

namespace RepoSimulator
{
    public class CommitNode : UnityEngine.Object
    {
        CommitNode(CommitNode previousNode)
        {
            this.previousNode = previousNode;

            time = DateTime.Now;
        }

        CommitNode previousNode { get; }
        string branchName { get; set; }
        string user;
        string message;
        DateTime time;
    }

    public class BranchSimulator : MonoBehaviour
    {
        const int MAX_NODES = 1000;

        public GameObject branchNodePrefab;

        private LineRenderer lineRenderer;
        private List<GameObject> commitNodes = new List<GameObject>();
        private float timeToSpawnNewNode = 0f;
        private Vector3 startPosition;
        private Vector3 currentSpawnPoint;
        private Vector3[] lineRendererPoints = new Vector3[MAX_NODES];

        // Start is called before the first frame update
        void Start()
        {
            startPosition = this.transform.position;
            currentSpawnPoint = startPosition;

            lineRendererPoints[0] = lineRendererPoints[1] = startPosition;

            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.startWidth = lineRenderer.endWidth = 0.2f;
            lineRenderer.startColor = lineRenderer.endColor = Color.white;
            lineRenderer.SetPositions(lineRendererPoints);

            AddNodeToTimeline();
            timeToSpawnNewNode = Random.Range(0.5f, 3f);
        }

        // Update is called once per frame
        void Update()
        {
            currentSpawnPoint += Vector3.right * 1.4f * Time.deltaTime;

            timeToSpawnNewNode -= Time.deltaTime;

            if (timeToSpawnNewNode <= 0f)
            {
                AddNodeToTimeline();
                
                timeToSpawnNewNode = Random.Range(0.5f, 3f);
            }
        }

        private void AddNodeToTimeline()
        {
            if(branchNodePrefab != null)
            {
                var newNode = Instantiate(branchNodePrefab);
                newNode.transform.position = currentSpawnPoint;

                commitNodes.Add(newNode);
                lineRendererPoints[commitNodes.Count - 1] = currentSpawnPoint;
                lineRenderer.positionCount = commitNodes.Count;
                lineRenderer.SetPosition(commitNodes.Count - 1, currentSpawnPoint);
            }
        }
    }
}